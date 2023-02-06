using System.ComponentModel.DataAnnotations;

namespace Mission4.Models
{
    /*Model for the calculator, stores all the grades*/
    public class GradeCalculationModel
    {
        [Range(0,100)]
        [Required]
        public int Assignments { get; set; }
        [Range(0,100)]
        [Required]
        public int GroupProject { get; set; }
        [Range(0,100)]
        [Required]
        public int Quizzes { get; set; }
        [Range(0,100)]
        [Required]
        public int MidtermExam { get; set; }
        [Range(0,100)]
        [Required]
        public int FinalExam { get; set; }
        [Range(0,100)]
        [Required]
        public int Intex { get; set; }
    }
}