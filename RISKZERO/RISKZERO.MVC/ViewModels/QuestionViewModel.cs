using RISKZERO.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RISKZERO.MVC.ViewModels
{
    public class QuestionViewModel
    {
        [Key]
        public int ID { get; private set; }
        [Display(Name = "Descrição")]
        public String Description { get; set; }
        [Display(Name = "Tipo de Pergunta")]
        public TypeQuestion TypeQuestion { get; set; }
        public bool Status { get; set; }
    }
}
