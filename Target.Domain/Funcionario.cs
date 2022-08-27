using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target.Domain
{
    public class Funcionario
    {
        private int id = 0;
        private string name;
        private string email;
        private int salary;
        private int age;
        private string role;

        public Funcionario()
        {

        }
        public Funcionario(string name, string email, int id, int salary, int age, string role)
        {
            this.name = name;
            this.email = email;
            this.id = id;
            this.salary = salary;
            this.age = age;
            this.role = role;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "O nome do usuário deve ser informado")]
        public string Name
        {

            get { return name; }
            set { name = value; }
        }

        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email
        {

            get { return email; }
            set { email = value; }

        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}

