using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProject.Poles.Dto;

namespace MyProject.Poles
{
    public interface IPoleAppService : IAsyncCrudAppService<PoleDto, Guid, PagedResultRequestDto, CreatePoleDto, PoleDto>
    {
    }
}