﻿﻿using System.ComponentModel.DataAnnotations;

namespace ApiGestaoFacil.Dtos
{
    public class ServidorDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres")]
        public required string Nome { get; set; }

        [Required]
        [Length(14, 14, ErrorMessage = "O cpf deve ter mínimo 14 caracteres")]
        public required string CPF { get; set; }

        [Required]
        public int Siape { get; set; }

        [Required]
        public int CampusId {get; set; }
    }
}