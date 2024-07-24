using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreBusines
{
    public class Cliente : Base
    {
        [Required(ErrorMessage = "O nome do cliente é obrigatóriol")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o seu email")]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Produto Produto { get; set; }
        public Logradouro Logradouro { get; set; }
    }
}
