using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Alunos")]
    public class Aluno
    {

        public Aluno()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos
        [Key]
        public int AlunoId { get; set; }
        [Display(Name = "Nome do Aluno:")]
      
        public String Nome { get; set; }
        
        [MinLength(10, ErrorMessage = "No mínimo 10 " +
            "caracteres!")]
        [MaxLength(10, ErrorMessage = "No máximo 10 " +
            "caracteres!")]
        [Display(Name = "Cpf:")]
        public String Cpf { get; set; }
        public DateTime CriadoEm { get; set; }
       
        public String Senha { get; set; }
        public String Imagem { get; set; }
        public String Sobre { get; set; }

    }
}
