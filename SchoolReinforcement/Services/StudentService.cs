using SchoolReinforcement.Entities;
using SchoolReinforcement.Interfaces.Repository;
using SchoolReinforcement.Interfaces.Service;

namespace SchoolReinforcement.Services
{
    public class StudentService : IService<Student>
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id).Result;
        }
    }
}
