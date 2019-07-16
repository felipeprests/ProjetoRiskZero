using RISKZERO.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RISKZERO.Domain.Entities
{
    public class Question
    {
        [Key]
        public int ID { get; private set; }
        [Display(Name = "Descrição")]
        public String Description { get; set; }
        [Display(Name = "Tipo de Pergunta")]
        public TypeQuestion TypeQuestion { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
