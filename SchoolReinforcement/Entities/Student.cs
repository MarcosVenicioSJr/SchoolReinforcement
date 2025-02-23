using SchoolReinforcement.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolReinforcement.Entities
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int SchoolGrade { get; set; }
        public StudentSituation Situation { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ResponsiblePerson { get; set; }
        public string ResponsiblePhone { get; set; }
        public int AcademicHistoryId { get; set; }
        public AcademicHistory AcademicHistory { get; set; }
    }
}