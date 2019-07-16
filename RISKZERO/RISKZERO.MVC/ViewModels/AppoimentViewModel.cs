using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RISKZERO.MVC.ViewModels
{
    public class AppoimentViewModel
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; private set; }
        [Display(Name = "Atendido por")]
        [ForeignKey("UserAppoiment")]
        public int UserID { get; set; }
        public virtual UserViewModel User { get; set; }
        [ForeignKey("PatientAppoiment")]
        public int PatientID { get; set; }
        public virtual PatientViewModel Patient { get; set; }
        [Display(Name = "Observações")]
        public string Observation { get; set; }
        [Display(Name = "Data e Hora")]
        public DateTime DateHour { get; set; }
        public bool Status { get; set; }
    }
}
