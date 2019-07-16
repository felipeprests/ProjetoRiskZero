using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RISKZERO.MVC.ViewModels
{
    public class UserViewModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; private set; }
        [Display(Name = "Nome Completo")]
        public String FullName { get; set; }
        [Required(ErrorMessage = "Preencha o campo CRP.")]
        public String CRP { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        [Display(Name = "Senha")]
        public String Password { get; set; }
        [Display(Name = "Nível de acesso")]
        public String Level { get; set; }
        [Display(Name = "Ativo")]
        public bool Status { get; set; }
        [Display(Name = "Ocupação")]
        public string Occupation { get; set; }
        [NotMapped]
        public PhoneUser PhoneUser { get; set; }
        [NotMapped]
        public AddressUser AddressUser { get; set; }
        [Display(Name = "Lembrar me")]
        public bool RememberMe { get; set; }
    }
}
