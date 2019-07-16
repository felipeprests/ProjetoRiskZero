using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RISKZERO.MVC.ViewModels
{
    public class PatientViewModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; private set; }
        [Display(Name = "Nome completo")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public long CPF { get; set; }
        public bool Status { get; set; }
        [Display(Name = "Endereço")]
        public string Address { get; set; }
        [JsonProperty(PropertyName = "patient_district")]
        [Display(Name = "Bairro")]
        public string District { get; set; }
        [JsonProperty(PropertyName = "patient_city")]
        [Display(Name = "Cidade")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "patient_state")]
        [Display(Name = "UF")]
        public string State { get; set; }
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        [Display(Name = "Tipo de telefone")]
        public string PhoneType { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}"), Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }
    }
}
