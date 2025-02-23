using SchoolReinforcement.Entities.Enums;

namespace SchoolReinforcement.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime InitDate { get; set; }
        public int SchoolGrade { get; set; }
        public StudentSituation Situation { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ResponsiblePhone { get; set; }
        public string ResponsiblePerson { get; set; }
        public AcademicHistory AcademicHistory { get; set; } = new AcademicHistory();
    }
}