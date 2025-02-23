using Microsoft.EntityFrameworkCore;
using SchoolReinforcement.Context;
using SchoolReinforcement.Entities;
using SchoolReinforcement.Interfaces.Repository;

namespace SchoolReinforcement.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }

        public async void Create(Student entity)
        {
            await _context.Students.AddAsync(entity);
            _context.SaveChanges();
        }

        public async Task<List<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
