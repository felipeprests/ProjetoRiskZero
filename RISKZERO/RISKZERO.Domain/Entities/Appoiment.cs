using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RISKZERO.Domain.Entities
{
    public class Appoiment
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; private set; }
        [Display(Name = "Atendido por")]
        [ForeignKey("UserAppoiment")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("PatientAppoiment")]
        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }
        [Display(Name = "Observações")]
        public string Observation { get; set; }
        [Display(Name = "Data e Hora")]
        public DateTime DateHour { get; set; }
        public bool Status { get; set; }
    }
}
