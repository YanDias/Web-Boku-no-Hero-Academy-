using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    [Table("Aulas")]
    public class Aula
    {
        //Construtor
        public Aula()
        {
            Professor = new Professor();
            CriadoEm = DateTime.Now;

        }
        //Atributos
        [Key]
        public int IdAula { get; set; }
        public String Tipo { get; set; }
        public String Local { get; set; }
        public String Data { get; set; }
        public Int32 Vagas { get; set; }
        public Professor Professor { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
