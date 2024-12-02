using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesMAUI.Resources.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório.")]
        public string Lastname { get; set; }

        [Range(18, 100, ErrorMessage = "A idade deve ser entre 18 e 100.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Endereço é obrigatório.")]
        public string Address { get; set; }
    }
}
