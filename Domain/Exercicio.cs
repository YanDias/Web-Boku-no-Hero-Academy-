using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Exercicios")]
    public class Exercicio
    {
        //Construtor
        public Exercicio()
        {
            ListaTreino = new ListaTreino();

            

        }
        //Atributos
        [Key]
        public int IdExercicios { get; set; }
        public String Equipamento { get; set; }
        public ListaTreino ListaTreino { get; set; }
        public Int32 Repeticoes { get; set; }
        public Int32 Quantidade { get; set; }
      

    }
}
