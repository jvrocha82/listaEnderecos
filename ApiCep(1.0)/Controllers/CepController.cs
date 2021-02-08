using ApiCep.Models;
using ApiCep.Services;
using Newtonsoft.Json;
using Refit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCep.Controllers
{
    public class CepController
    {
        public static async System.Threading.Tasks.Task<object> NumeroCepAsync(string cep)
        {

            var cepClient = RestService.For<EnderecoService>("https://viacep.com.br");


            object address = await cepClient.GetAddressAsync(cep);
           

            return address;
        }
    }
}