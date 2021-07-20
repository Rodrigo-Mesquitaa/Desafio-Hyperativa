using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.hyperativa.Core.Interfaces
{
    public interface IArquivoService
    {
        bool ProcessarArquivo(IFormFile file);
    }
}
