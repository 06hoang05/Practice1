using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class Exam 
    {
        [Key]
        public long ExamId { get; set; }

        [Required]
        [Range(0, 100)]
        public int Score { get; set; }

        public long StudentId { get; set; }

        public int SubjectId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}
