using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp
{
    public class ContactForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "L'adresse e-mail est obligatoire")]
        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse e-mail valide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Veuillez entrer votre message")]
        public string Message { get; set; }
    }
}
