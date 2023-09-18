using WebApplication7.ViewModels.Students;
namespace WebApplication7.Services.Interfaces
{
    public interface IStudentService
    {
        public int Add(StudentEditViewModel model);
        public void Delete(int Id);
        public int Update(StudentEditViewModel model);

        public StudentEditViewModel GetById(int Id);
    }
}
