using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target.Domain;

namespace Target.Repository
{
    //Função com o banco de dados ativo.// 
    public static class FuncionarioRepository
    {
        public static SQLServeClass db;

        public static bool CadastroFuncionario(string name, string email, int salary, int age, string role)
        {


            try
            {
                db = new SQLServeClass(); //abro a conexão com o banco de dados
                var SQL = "INSERT INTO Funcionario(Name, Email, Salary, Age, Role) VALUES('" + name + "', '" + email + "', '" + salary + "', '" + age + "', '" + role + "' )"; //comando SQL 
                var dt = db.SQLQuery(SQL); //Retorno do Banco em formato de tabela

                return true;
            }
            catch (Exception ex)
            {

                return false;

            }


        }

        public static List<Funcionario> GetAll()
        {
            List<Funcionario> pFuncionario = new List<Funcionario>();

            try
            {
                db = new SQLServeClass(); //abro a conexão com o banco de dados
                var SQL = "SELECT * FROM  Funcionario "; //comando SQL 
                var dt = db.SQLQuery(SQL); //Retorno do Banco em formato de tabela
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        Funcionario funcionario = new Funcionario();
                        funcionario.Id = int.Parse(dt.Rows[i]["id"].ToString());
                        funcionario.Name = dt.Rows[i]["name"].ToString();
                        funcionario.Email = dt.Rows[i]["email"].ToString();
                        funcionario.Age = int.Parse(dt.Rows[i]["age"].ToString());
                        funcionario.Salary = int.Parse(dt.Rows[i]["salary"].ToString());
                        funcionario.Role = dt.Rows[i]["role"].ToString();

                        pFuncionario.Add(funcionario);
                    }
                }
                return pFuncionario;
            }
            catch (Exception ex)
            {
                
                return pFuncionario;
            }

        }
        public static Funcionario LocalizarFuncionario(int id)
        {

            try
            {
                db = new SQLServeClass(); //abro a conexão com o banco de dados
                var SQL = "SELECT * FROM Funcionario WHERE Id = '" + id + "' "; ; //comando SQL 
                var dt = db.SQLQuery(SQL); //Retorno do Banco em formato de tabela
                if (dt.Rows.Count > 0)
                {

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id = int.Parse(dt.Rows[0]["id"].ToString());
                    funcionario.Name = dt.Rows[0]["name"].ToString();
                    funcionario.Email = dt.Rows[0]["email"].ToString();
                    funcionario.Age = int.Parse(dt.Rows[0]["age"].ToString());
                    funcionario.Salary = int.Parse(dt.Rows[0]["salary"].ToString());
                    funcionario.Role = dt.Rows[0]["role"].ToString();
                    return funcionario;
                }

                return null;

            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public static bool Editar(int id, string name, string email, int salary, int age, string role)
        {
            try
            {

                db = new SQLServeClass(); //abro a conexão com o banco de dados
                var SQL = "";
                if (name != null)
                {
                     SQL = "UPDATE Funcionario SET Name = '"+ name +"' WHERE Id = '" + id + "' ";
                } 
                if (email != null)
                {
                     SQL = "UPDATE Funcionario SET Email = '"+ email +"' WHERE Id = '" + id + "' ";
                }
                if(salary != 0)
                {
                    SQL = "UPDATE Funcionario SET Salary = '"+ salary +"' WHERE Id = '" + id + "' ";

                }
                if(age != 0)
                {
                    SQL = "UPDATE Funcionario SET Age = '"+ age +"' WHERE Id = '" + id + "' ";

                }
                if(role != null)
                {
                    SQL = "UPDATE Funcionario SET Role = '"+ role +"' WHERE Id = '" + id + "' ";

                }

                var dt = db.SQLQuery(SQL); //Retorno do Banco em formato de tabela

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            //UPDATE Funcionario SET age = 5, salary = 0, Name = '' WHERE id = 1

        }

        public static bool RemoverFuncionario(int id)
        {

            try
            {
                db = new SQLServeClass(); //abro a conexão com o banco de dados
                var SQL = "DELETE FROM  Funcionario WHERE Id = '" + id + "' "; ; //comando SQL 
                var dt = db.SQLQuery(SQL); //Retorno do Banco em formato de tabela

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}