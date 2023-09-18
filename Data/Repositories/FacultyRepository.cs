using WebApplication7.Data.Entities;
using WebApplication7.Data.Repositories.Interfaces;

namespace WebApplication7.Data.Repositories
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly UniversityDataContext _context;
        public FacultyRepository(UniversityDataContext context)
        {
            _context = context;
        }
        public void Add(Faculty faculty)
        {
           _context.Faculties.Add(faculty);
            _context.SaveChanges();
        }

        public void Delete(Faculty faculty)
        {
           _context.Faculties.Remove(faculty);
            _context.SaveChanges();
        }

        public List<Faculty> GetAll()
        {
            return _context.Faculties.ToList();

        }

        public Faculty GetById(int id)
        {
           return  _context.Faculties.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
