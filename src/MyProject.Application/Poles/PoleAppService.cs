using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyProject.Poles.Dto;
using MyProject.PolesManagement.Poles;

namespace MyProject.Poles
{
    public class PoleAppService : AsyncCrudAppService<Pole, PoleDto, Guid, PagedResultRequestDto, CreatePoleDto, PoleDto>, IPoleAppService
    {
		public PoleAppService(IRepository<Pole, Guid> repository) : base(repository)
        {
        }
    }
}
