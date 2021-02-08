using ApiCep.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace ApiCep.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers:"*",methods:"*")]
    public class EnderecoController : ApiController
    {
        private static List<Endereco> p = new List<Endereco>();

        public async System.Threading.Tasks.Task<object> GetAsync(string cep)
        {
            object address = await CepController.NumeroCepAsync(cep);
            return address;
        }
        public object Get()
        {
           return p;
        }
        public async System.Threading.Tasks.Task<object> PostAsync(string cep)
        {
            object address = await CepController.NumeroCepAsync(cep);
            p.Add((Endereco)address);
            return p;
        }


    }
}
