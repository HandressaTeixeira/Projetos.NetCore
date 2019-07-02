﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class Login
    {

        [Required(ErrorMessage ="O email é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public Login()
        {

        }
    }
}
