using WebApplication7.Data.Entities;

namespace WebApplication7.Data.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        Student GetById(int id);
        List<Student> GetAll();
        void Delete(Student student);
        void SaveChanges();
    }
}
