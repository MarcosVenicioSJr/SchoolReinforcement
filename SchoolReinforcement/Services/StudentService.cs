using SchoolReinforcement.Entities;
using SchoolReinforcement.Entities.Requests;
using SchoolReinforcement.Interfaces.Repository;
using SchoolReinforcement.Interfaces.Service;
using SchoolReinforcement.Mapper;

namespace SchoolReinforcement.Services
{
    public class StudentService : IService<Student>
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(CreateStudentRequest request)
        {
            Student entity = CreateStudentMapper.MapperDataStudent(request);

            _studentRepository.Create(entity);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll().Result;
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id).Result;
        }
    }
}
