using ApiCep.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ApiCep.Services
{
    public interface EnderecoService
    {
        [Get("/ws/{cep}/json")]
        Task<Endereco> GetAddressAsync(string cep);
    }
}