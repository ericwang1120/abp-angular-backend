using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProject.Lines.Dto;

namespace MyProject.Lines
{
    public interface ILineAppService : IAsyncCrudAppService<LineDto, Guid, PagedResultRequestDto, CreateLineDto, LineDto>
    {
    }
}