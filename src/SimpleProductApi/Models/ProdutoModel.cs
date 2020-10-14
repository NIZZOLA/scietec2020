using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProductApi.Models
{
    [Table("Produtos")]
    public class ProdutoModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [MaxLength(50)]
        public string Descricao { get; set; }

        public UnidadeDeMedidaEnum Unidade { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorDeCusto { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal MargemDeLucro { get; set; }

        public decimal ValorDeVenda { get { return this.ValorDeCusto + (this.ValorDeCusto * this.MargemDeLucro / 100); } }

        [MaxLength(13)]
        public string CodigoDeBarras { get; set; }

        [Column(TypeName = "decimal(12,3)")]
        public decimal Estoque { get; set; }

        public bool Ativo { get; set; }
    }
}
