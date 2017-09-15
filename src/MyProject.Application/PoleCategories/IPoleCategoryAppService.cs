using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProject.PoleCategories.Dto;

namespace MyProject.PoleCategories
{
    public interface IPoleCategoryAppService : IAsyncCrudAppService<PoleCategoryDto, Guid, PagedResultRequestDto, CreatePoleCategoryDto, PoleCategoryDto>
    {
    }
}