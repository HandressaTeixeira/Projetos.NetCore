using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Categoria
    {

        public Guid IdCategoria { get; set; }
        //[Required(ErrorMessage = "A categoria é obrigatória")]
        [Display(Name = "Categoria")]
        public string Nome { get; set; }

        public Categoria()
        {
            IdCategoria = Guid.NewGuid();
        }
    }
}
