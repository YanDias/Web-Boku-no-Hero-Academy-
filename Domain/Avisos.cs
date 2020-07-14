using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    [Table("Avisos")]
    public class Avisos
    {
        //Construtor
        public Avisos()
        {
            CriadoEm = DateTime.Now;

        }
        //Atributos
        [Key]
        public int IdAviso { get; set; }
        public String Tipo { get; set; }
        public String Descricao { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
