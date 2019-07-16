using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RISKZERO.Domain.Entities
{
    public class Agenda
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Data e hora")]
        public DateTime DateHour { get; set; }
        [Display(Name = "Lembrete")]
        public String Reminder { get; set; }
        public bool Status { get; set; }
        [Display(Name = "Notificar")]
        public bool Notification { get; set; }
    }
}
