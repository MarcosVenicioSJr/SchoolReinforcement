using SchoolReinforcement.Entities.Requests;
using SchoolReinforcement.Entities;

namespace SchoolReinforcement.Mapper
{
    public static class CreateStudentMapper
    {
        public static AcademicHistory MapperHistoricAcademic(CreateStudentRequest request)
        {
            AcademicHistory academicHistory = new AcademicHistory();

            if (request.AcademicHistory.Subjects.Count == 0)
                return academicHistory;

            foreach (var requestSubject in request.AcademicHistory.Subjects)
            {
                Subject subject = new Subject
                {
                    Name = requestSubject.Name,
                    Grade = requestSubject.Grade,
                    GradeReceivedDate = requestSubject.GradeReceivedDate
                };

                academicHistory.Subjects.Add(subject);
            }

            return academicHistory;
        }

        public static Student MapperDataStudent(CreateStudentRequest request)
        {
            return new Student
            {
                Name = request.Name,
                Address = request.Address,
                BirthDate = request.BirthDate,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                ResponsiblePerson = request.ResponsiblePerson,
                ResponsiblePhone = request.ResponsiblePhone,
                SchoolGrade = request.SchoolGrade,
                Situation = request.Situation,
                AcademicHistory = MapperHistoricAcademic(request)
            };
        }
    }
}
