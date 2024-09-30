using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEntity
{
    public class PatientDBModel
    {

        public int PatientID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "The field is required.")]
        [MaxLength(100, ErrorMessage = "Max Charactor should be less then 50.")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "The field is required.")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "The field is required.")]
        [MaxLength(10, ErrorMessage = "Max Charactor should be less then 50.")]
        public string Gender { get; set; }

        [Display(Name = "Contact")]
        [Required(ErrorMessage = "The field is required.")]
        [MaxLength(10, ErrorMessage = "Max Charactor should be less then 50.")]
        public string Contact { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "The field is required.")]
        [MaxLength(255, ErrorMessage = "Max Charactor should be less then 50.")]
        public string Address { get; set; }

        [Display(Name = "Medical History")]
        [MaxLength(2000, ErrorMessage = "Max Charactor should be less then 50.")]
        public string MedicalHistory { get; set; }

    }
}
