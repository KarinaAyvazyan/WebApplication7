using WebApplication7.ViewModels.Faculties;

namespace WebApplication7.Services.Interfaces
{
    public interface IFacultyService
    {
        public List<FacultyDropdownViewModel> GetListForDropdown();
        public void Add(FacultyAddEdit facultyAddEdit);
    }
}
