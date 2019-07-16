using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RISKZERO.MVC.ViewModels
{
    public class AnswerViewModel
    {
        [Key]
        public int ID { get; private set; }
        [Display(Name = "Resposta Final")]
        public bool Result { get; set; }
        [Display(Name = "Observações")]
        public String Observation { get; set; }
        public int QuestionID { get; set; }
        public virtual QuestionViewModel Question { get; set; }
        public bool Status { get; set; }
        public string TypeAnswer { get; set; }
    }
}
