using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using MyProject.Poles.Dto;
using MyProject.PolesManagement.Poles;

namespace MyProject.Poles
{
    public class PoleAppService : AsyncCrudAppService<Pole, PoleDto, Guid, PagedResultRequestDto, CreatePoleDto, PoleDto>, IPoleAppService
    {
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        public PoleAppService(IUnitOfWorkManager unitOfWorkManager, IRepository<Pole, Guid> repository) : base(repository)
        {
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<PagedResultDto<Pole>> getAllIncludeDeleted()
        {
            using (_unitOfWorkManager.Current.DisableFilter(AbpDataFilters.SoftDelete))
            {
                var allPoles = Repository.GetAllList();
                return await Task.FromResult(new PagedResultDto<Pole>(0,
                    allPoles
                ));
            }
        }
    }
}
