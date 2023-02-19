using System.ComponentModel.DataAnnotations;

namespace WebIdentity.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "İstifadəçi adı daxil et")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Şifrəni daxil et")]
        public string Password { get; set; }
    }
}
