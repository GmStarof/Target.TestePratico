using System.Collections.Generic;
using Target.Domain;
using Target.Repository;

namespace Target.Service
{
    public class FuncionarioService
    {
        public List<Funcionario> getFuncionario()
        {
            return FuncionarioRepository.GetAll();
        }
        public bool Remover(int id)
        {

            return FuncionarioRepository.RemoverFuncionario(id);
        }
        public bool Cadastrar(string nome, string email, int salary, int age, string role)
        {
            return FuncionarioRepository.CadastroFuncionario(nome, email, salary, age, role);

        }
        public bool EditarFuncionario(int id, string name, string email, int salary, int age, string role)
        {
            return FuncionarioRepository.Editar(id,name,email,salary,age,role);
        }
        public Funcionario LocalizarFuncionario(int id)
        {
            return FuncionarioRepository.LocalizarFuncionario(id);
        }

    }
}
