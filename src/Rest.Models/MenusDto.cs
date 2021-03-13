﻿using Rest.Domain.Entities;
using Rest.Models.Base;
using System;

namespace Rest.Models
{
    public class MenusDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool DayMenu { get; set; }
        public int? IdMenuParent { get; set; }


        public static implicit operator MenusDto(Menus domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new MenusDto()
            {
                Description = domainEntity.Description,
                Id = domainEntity.Id,
                Name = domainEntity.Name,
                Date = domainEntity.Date,
                DayMenu = domainEntity.DayMenu,
                IdMenuParent = domainEntity.IdMenuParent
            };
        }
        public static implicit operator Menus(MenusDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Menus()
            {
                Description = dto.Description,
                Name = dto.Name,
                Id = dto.Id,
                Date = dto.Date,
                IdMenuParent = dto.IdMenuParent,
                DayMenu = dto.DayMenu
            };
        }
    }
}
