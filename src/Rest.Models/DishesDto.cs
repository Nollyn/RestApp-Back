using Rest.Core;
using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class DishesDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int IdCategory { get; set; }

        public static implicit operator DishesDto(Dishes domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new DishesDto()
            {
                Description = domainEntity.Description,
                Id = domainEntity.Id,
                Name = domainEntity.Name,
                Price = domainEntity.Price,
                Image = domainEntity.Image.ToBase64(),
                IdCategory = domainEntity.IdCategory
            };
        }
        public static implicit operator Dishes(DishesDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Dishes()
            {
                Description = dto.Description,
                Price = dto.Price,
                Name = dto.Name,
                Image = dto.Image.FromBase64(),
                Id = dto.Id,
                IdCategory = dto.IdCategory
            };
        }
    }
}
