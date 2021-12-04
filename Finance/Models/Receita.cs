using System;
using System.ComponentModel.DataAnnotations;

namespace Finance.Models
{
    public class Receita
    {
        [Key]
        public int ReceitaId { get; set; }
        public TipoReceita Receita_Nome { get; set; }
        public DateTime Data_Entrada { get; set; }
        public double Receita_Valor { get; set; }
    }

    public enum TipoReceita
    {
        Salario,
        Extra
    }
}