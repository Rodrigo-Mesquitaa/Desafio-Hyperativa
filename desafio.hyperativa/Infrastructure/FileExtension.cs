using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.hyperativa.Infrastructure
{
    public static class FileExtension
    {
        public static List<string> ReadFile(this IFormFile value)
        {
            var conteudo = new List<string>();
            using (var reader = new StreamReader(value.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    conteudo.Add(reader.ReadLine());
            }
            return conteudo;
        }
    }
}
