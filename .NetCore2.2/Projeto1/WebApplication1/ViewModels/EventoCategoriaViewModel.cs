using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class EventoCategoriaViewModel
    {
        public Evento Evento { get; set; }

        public IEnumerable<Categoria> Categoria { get; set; }

        public EventoCategoriaViewModel()
        {
            Evento = new Evento();
        }

    }
}
