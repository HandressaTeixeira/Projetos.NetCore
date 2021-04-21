using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Usuario
    {
        public Guid IdUsuario { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }

        public string Senha { get; set; }

        public Usuario()
        {
            IdUsuario = Guid.NewGuid();
        }

    }
}
