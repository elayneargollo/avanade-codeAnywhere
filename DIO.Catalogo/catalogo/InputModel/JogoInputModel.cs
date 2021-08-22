﻿using System;
using System.ComponentModel.DataAnnotations;

namespace catalogo.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage ="O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Produtora { get; set; }

        [Required]
        [Range(1,100, ErrorMessage = "O preço deve ser no mínimo 1 real e no máximo 100 reais")]
        public decimal Preco { get; set; }
    }
}
