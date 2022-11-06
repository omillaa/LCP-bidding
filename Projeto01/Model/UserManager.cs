using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal class UserManager
    {
        private string nome;
        private string email;
        private string senha;
        private DateTime cadastro;
        private DateTime alteracao;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public DateTime Cadastro { get => cadastro; set => cadastro = value; }
        public DateTime Alteracao { get => alteracao; set => alteracao = value; }
    }
}
