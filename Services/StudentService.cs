using WebApplication7.Services.Interfaces;
using WebApplication7.Data.Repositories.Interfaces;
using WebApplication7.ViewModels.Students;
using WebApplication7.Data.Entities;

namespace WebApplication7.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository )
        {
            _studentRepository = studentRepository;
        }
        public int Add(StudentEditViewModel model)
        {
            Student student = new()
            {
                FacultyId = model.FacultyId,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };
            _studentRepository.Add(student);
            return student.Id;
        }

        public void Delete(int id)
        {
           var entity= _studentRepository.GetById( id );
           _studentRepository.Delete(entity);

        }
        public StudentEditViewModel GetById(int Id)
        {
            var entity = _studentRepository.GetById(Id);
            return new StudentEditViewModel
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Id = entity.Id,
                FacultyId = entity.FacultyId
            };
        }


        public int Update(StudentEditViewModel model)
        {
            var entity = _studentRepository.GetById(model.Id);
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.FacultyId = entity.FacultyId;
            _studentRepository.SaveChanges();
            return entity.Id;
        }
    }
}
