using SchoolReinforcement.Entities.DTOs;
using SchoolReinforcement.Entities.Enums;

namespace SchoolReinforcement.Entities.Requests
{
    public class CreateStudentRequest
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentSituation Situation { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ResponsiblePerson { get; set; }
        public string ResponsiblePhone { get; set; }
        public int SchoolGrade { get; set; }
        public AcademicHistoryDTO AcademicHistory { get; set; }
    }
}
