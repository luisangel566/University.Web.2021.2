using System;
using System.ComponentModel.DataAnnotations;

namespace University.BL.DTOs
{
    public class DepartmentDTO
    {
        [Display(Name = "DepartmentID")]
        [Required(ErrorMessage = "El campo DepartmentID es requerido.")]
        public int DepartmentID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "El campo Name es requerido.")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Budget")]
        [Required(ErrorMessage = "El campo Budget es requerido.")]
        public decimal Budget { get; set; }

        [Display(Name = "StartDate")]
        [Required(ErrorMessage = "El campo StartDate es requerido.")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        //nav
        public int InstructorID { get; set; }

        public InstructorDTO Instructor { get; set; }

    }
}