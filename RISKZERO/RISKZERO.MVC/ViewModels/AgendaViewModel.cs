using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RISKZERO.MVC.ViewModels
{
    public class AgendaViewModel
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
