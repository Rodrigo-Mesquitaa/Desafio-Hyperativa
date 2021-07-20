using desafio.hyperativa.Core.Interfaces;
using desafio.hyperativa.Domain.Entities;
using desafio.hyperativa.Domain.Interfaces;
using desafio.hyperativa.Infrastructure;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Abstractions;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.hyperativa.Domain.Services
{

    public class ArquivoService : IArquivoService
    {
        private readonly IArquivoRepository arquivoRepository;

        public ArquivoService(IArquivoRepository arquivoRepository)
        {
            this.arquivoRepository = arquivoRepository;
        }

        public bool ProcessarArquivo(IFormFile file)
        {
            var arquivo = GetArquivo(file);
           //Salvar arquivo
           //Salvar Cartoes
            return true;
        }

        private Arquivo GetArquivo(IFormFile file)
        {
            var arquivo = new Arquivo();
            var conteudoArquivo = file.ReadFile();
            arquivo.Nome = conteudoArquivo[0].ToString().Substring(0, 29);
            arquivo.Data = DateTime.ParseExact(conteudoArquivo[0].ToString().Substring(29, 8), "yyyyMMdd", CultureInfo.InvariantCulture);
            arquivo.Lote = conteudoArquivo[0].ToString().Substring(37, 8);
            arquivo.QtdRegistro = int.Parse(conteudoArquivo[0].ToString().Substring(45, 7));
            arquivo.Cartoes = new List<Cartao>();
            for (int i = 1; i < conteudoArquivo.Count - 2; i++)
            {
                var cartao = new Cartao
                {
                    Lote = conteudoArquivo[i].ToString().Substring(1, 5),
                    NumeroCartao = conteudoArquivo[i].ToString().Substring(5, 18)
                };
                arquivo.Cartoes.Add(cartao);
            }
            return arquivo;
        }
    }
}
