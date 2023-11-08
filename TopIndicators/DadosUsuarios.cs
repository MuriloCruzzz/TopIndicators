using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosUsuarios
{
    public class Usuario
    {

        public int Id;
        public string Nome;
        public string Setor;
        public string Senha;
        private object value;

        public Usuario(object value)
        {
            this.value = value;
        }
    }

}