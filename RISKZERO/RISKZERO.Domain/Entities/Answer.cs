using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RISKZERO.Domain.Entities
{
    public class Answer
    {
        [Key]
        public int ID { get; private set; }
        [Display(Name = "Resposta Final")]
        public bool Result { get; set; }
        [Display(Name = "Observações")]
        public String Observation { get; set; }
        public int QuestionID{ get; set; }
        public virtual Question Question { get; set; }
        public bool Status { get; set; }
        public string TypeAnswer { get; set; }


        //public int IdPatient { get; set; }
        //public int IdAppoiment { get; set; }
        //public ICollection<Answer> Answers { get; set; }
    }
}
