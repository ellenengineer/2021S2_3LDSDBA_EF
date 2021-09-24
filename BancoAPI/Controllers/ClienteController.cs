using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoAPI.Models;
using BancoAPI.Context;
using BancoAPI.Aplicacao;


namespace BancoAPI.Controllers
{
    [Route("banco/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly BANCOContext _context;
        public ClienteController(BANCOContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Cliente> Get()
        {
            ClienteAplicacao objAppCli = new ClienteAplicacao(_context);

            try
            {
                return objAppCli.GetAllClients();
            }
            catch (Exception ex)
            {
                var retorno = new List<Cliente>();
                var cli = new Cliente();
                cli.Nome = ex.Message;
                retorno.Add(cli);
                return retorno;
            }

        }

        [HttpGet("{codCli}")]
        public Cliente Get(int codCli)
        {
            ClienteAplicacao objAppCli = new ClienteAplicacao(_context);
            return objAppCli.GetCliByID(codCli);
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        [HttpPut("{CodCli}")]
        public void Put([FromBody] Cliente cli)
        {
            ClienteAplicacao objAppCli= new ClienteAplicacao(_context);

            if (cli.CodCli > 0)
            {
                objAppCli.AtualizarCliente(cli);
            }
            else
            {
                objAppCli.InserirCliente(cli);
            }

        }

        [HttpDelete("{codCli}")]
        public void Delete(int codCli)
        {
            ClienteAplicacao objAppCli = new ClienteAplicacao(_context);
            objAppCli.DeleteClientByCod(codCli);
        }
    }
}
