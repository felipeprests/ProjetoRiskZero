using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Domain.Entities
{
    public class Statistic
    {
        public int ID { get; private set; }
        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }
        public string Tendency { get; set; }
        public string Reference { get; set; }
        public int QuantityAnswered { get; set; }
        public int TotalAnsweredYes { get; set; }
        public int TotalAnsweredNo { get; set; }
        public float PercentageYes { get; set; }
        public float PercentageNo { get; set; }
        public string Level { get; set; }
        public DateTime DateHour { get; set; }
    }
}
