using WebApplication7.Data.Entities;
using WebApplication7.Data.Repositories.Interfaces;
using WebApplication7.ViewModels.Faculties;

namespace WebApplication7.Services
{
    public class FacultyService
    {
        private readonly IFacultyRepository _facultyRepository;
        public FacultyService(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }
        public List<FacultyDropdownViewModel> GetListForDropdown() 
        {
            var data = _facultyRepository.GetAll();
            return data.Select(f => new FacultyDropdownViewModel
            {
                Id = f.Id,
                Name = f.Name,
            }).ToList();
        }
        public void Add(FacultyAddEdit facultyAddEdit)
        {
            Faculty faculty = new Faculty()
            {
                Name = facultyAddEdit.Name,
                RoomCount = facultyAddEdit.RoomCount,
            };
            _facultyRepository.Add(faculty);
        }
    }
}
