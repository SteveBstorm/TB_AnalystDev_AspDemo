using System.ComponentModel.DataAnnotations;

namespace AspDemo.FormModels
{
    public class ClientForm
    {
        [Required]
        [MinLength(5, ErrorMessage = "Le nom doit contenir au moins 5 charactères")]
        [MaxLength(20)]
        public string Name { get; set; }
        
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les deux mots de passe doivent correspondre")]
        public string ConfirmPassword { get; set; }
    }
}
