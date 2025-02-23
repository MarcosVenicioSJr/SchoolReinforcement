using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolReinforcement.Entities
{
    [Table("AcademicHistories")]
    public class AcademicHistory
    {
        public int Id { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}