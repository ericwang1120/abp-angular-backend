using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyProject.PolesManagement.PoleCategories;


namespace MyProject.PoleCategories.Dto
{
    [AutoMapFrom(typeof(PoleCategory)), AutoMapTo(typeof(PoleCategory))]
    public class PoleCategoryDto : EntityDto<Guid>
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}