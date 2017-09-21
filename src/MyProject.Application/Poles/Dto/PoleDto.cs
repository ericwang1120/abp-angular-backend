using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyProject.PolesManagement.Poles;


namespace MyProject.Poles.Dto
{
    [AutoMapFrom(typeof(Pole)), AutoMapTo(typeof(Pole))]
    public class PoleDto : EntityDto<Guid>
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid PoleCategoryId { get; set; }
        [Required]
        public decimal Height { get; set; }
        [Required]
        public decimal Longitude { get; set; }
        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public string Description { get; set; }
    }
}