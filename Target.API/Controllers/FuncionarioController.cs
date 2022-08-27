using Microsoft.AspNetCore.Mvc;
using System.Net;
using Target.Domain;
using Target.Service;
using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Web.Http;



namespace Target.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        FuncionarioService funcionarioService = new FuncionarioService();


        [HttpHead (Name = "Funcionarios")]
        public IEnumerable<Funcionario> Get()
        {

            return funcionarioService.getFuncionario();
        }

        [HttpGet(Name = "Localizar Funcionario")]
        public Funcionario Get(int id)
        {

            return funcionarioService.LocalizarFuncionario(id);


        }
        [HttpPost(Name = "Cadastrar Funcionario")]

        public bool Post(string name, string email, int salary, int age, string role)
        {
            try
            {
                funcionarioService.Cadastrar(name, email, salary, age, role);
                return true;
            }
            catch { return false; }
            
        }
        [HttpPut(Name = "Editar Funcionario")]
        public bool Put(int id,string name, string email, int salary, int age, string role)
        {
            try
            {
               //funcionarioService.EditarFuncionario(id,name,email,salary,age,role);
                return true;
            }
            catch 
            { 
                return false; 
            }

        }
        [HttpDelete(Name ="Deletar Funcionario")]
        public bool Delete(int id)
        {

            try
            {
                funcionarioService.Remover(id);
                return true;
            }
            catch { return false; }
        }
    }
}