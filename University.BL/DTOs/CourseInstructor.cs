using System.ComponentModel.DataAnnotations;

namespace University.BL.DTOs
{
    public class CourseInstructorDTO
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "El campo ID es requerido.")]
        public int ID { get; set; }


        [Display(Name = "CourseID")]
        [Required(ErrorMessage = "El campo CourseID es requerido.")]
        public int CourseID { get; set; }


        [Display(Name = "InstructorID")]
        [Required(ErrorMessage = "El campo InstructorID es requerido.")]
        public int InstructorID { get; set; }

        //nav
        public CourseDTO Course { get; set; }
        public InstructorDTO Instructor { get; set; }
    }
}