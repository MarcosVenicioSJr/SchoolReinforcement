using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolReinforcement.Entities
{
    [Table("Subjects")]
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Precision(18, 2)]
        public double Grade { get; set; }
        public DateTime GradeReceivedDate { get; set; }
        public int AcademicHistoryId { get; set; }
        public AcademicHistory AcademicHistory { get; set; }
    }
}
