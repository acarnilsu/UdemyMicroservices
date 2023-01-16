using FreeCourse.Shared.Dtos;
using FreeCourseServices.Catalog.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourseServices.Catalog.Services
{
    internal interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(CategoryDto category);

        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
