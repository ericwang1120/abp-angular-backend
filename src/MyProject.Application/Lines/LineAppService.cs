using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyProject.Lines.Dto;
using MyProject.PolesManagement.Lines;

namespace MyProject.Lines
{
    public class LineAppService : AsyncCrudAppService<Line, LineDto, Guid, PagedResultRequestDto, CreateLineDto, LineDto>, ILineAppService
    {
        public LineAppService(IRepository<Line, Guid> repository) : base(repository)
        {
        }
    }
}
