using System.ComponentModel.DataAnnotations;

namespace University.BL.DTOs
{
    public class EnrollmentDTO
    {
        [Display(Name = "EnrollmentID")]
        [Required(ErrorMessage = "El campo EnrollmentID es requerido.")]
        public int EnrollmentID { get; set; }

        [Display(Name = "CourseID")]
        [Required(ErrorMessage = "El campo CourseID es requerido.")]
        public int CourseID { get; set; }

        [Display(Name = "StudentID")]
        [Required(ErrorMessage = "El campo StudentID es requerido.")]
        public int StudentID { get; set; }


        public CourseDTO Course { get; set; }
        public StudentDTO Student { get; set; }

    }
}