using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlDeAcceso.Data.Entities
{
    public class DocumentType
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Tipo Identificacion")]
        public string Name { get; set; }

        public  ICollection<User> User { get; set; }
    }
}
