using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyProject.PolesManagement.Lines;


namespace MyProject.Lines.Dto
{
    [AutoMapTo(typeof(Line))]
    public class CreateLineDto
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public Guid BeginPoleId { get; set; }
        [Required]
        public Guid EndPoleId { get; set; }
        public string Description { get; set; }
    }
}