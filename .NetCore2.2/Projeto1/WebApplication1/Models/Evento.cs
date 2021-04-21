using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Evento
    {
        [Key]
        public Guid IdEvento { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome Completo")]
        [MaxLength(100, ErrorMessage = "O valor máximo é 100")]
        public string Nome { get; set; }

        [Range(10, 1000)]
        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        public decimal Valor { get; set; }

        public bool Gratuito { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatória")]
        [MaxLength(500, ErrorMessage = "A quantidade maxima de caracteres é 500")]
        public string Descricao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "O campo Data é obrigatório")]
        public DateTime Data { get; set; }

        public Evento()
        {
            IdEvento = Guid.NewGuid();
        }

    }
}
