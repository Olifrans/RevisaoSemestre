using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusines
{
    public class Produto : Base
    { 
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        public decimal Valor { get; set; }
        public string NomeImagem { get; set; }
        public DateTime DataDeCompra { get; set; }
        public bool Situacao { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
