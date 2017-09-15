using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyProject.PoleCategories.Dto;
using MyProject.PolesManagement.PoleCategories;

namespace MyProject.PoleCategories
{
    public class PoleCategoryAppService : AsyncCrudAppService<PoleCategory, PoleCategoryDto, Guid, PagedResultRequestDto, CreatePoleCategoryDto, PoleCategoryDto>, IPoleCategoryAppService
    {
        public PoleCategoryAppService(IRepository<PoleCategory, Guid> repository) : base(repository)
        {
        }
    }
}
