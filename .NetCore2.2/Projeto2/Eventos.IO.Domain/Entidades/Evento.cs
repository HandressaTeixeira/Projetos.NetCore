using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Negocio.Entidades
{
    public class Evento : EntidadeBase
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim{ get; set; }

        public bool Gratuito { get; set; }

        public decimal Valor { get; set; }

        public bool Online { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<Tags> Tags { get; set; }
        
        public Endereco Endereco { get; set; }

        public Organizador Organizador { get; set; }

        public Evento()
        {
            Id = Guid.NewGuid();
        }
    }
}
