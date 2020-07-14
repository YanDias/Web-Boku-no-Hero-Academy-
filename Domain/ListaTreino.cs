using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("ListaTreinos")]
    public class ListaTreino
    {
        //Construtor
        public ListaTreino()
        {
            CriadoEm = DateTime.Now;

        }



        //Atributos
        [Key]
        public int IdListaTreino { get; set; }
        [Display(Name = "Dia da Semana:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public String DSemana { get; set; }

        [Display(Name = "Nome da Lista:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public String NomeLista { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}
