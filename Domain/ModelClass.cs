using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    
    public class ModelClass
    {

        public ModelClass()
        {
            professor = new Professor();
            exercicio = new Exercicio();
        }
        public Professor professor { get; set; }
        public Exercicio exercicio { get; set; }
    }
}
