using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        
        public string Cognome { get; set; }

        [Display(Name = "Contatto Attivo")]
        public bool IsAttivo { get; set; }

        public string DisplayName
        { 
            get
            {
                return this.Nome + (this.Cognome != null ? " " + this.Cognome : string.Empty);
            }
        }

        public Contact()
        {
            this.IsAttivo = true;
        }
    }
}