using Rest.Core;
using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class DrinksDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public static implicit operator DrinksDto(Drinks domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new DrinksDto()
            {
                Description = domainEntity.Description,
                Id = domainEntity.Id,
                Image = domainEntity.Image.ToBase64(),
                Name = domainEntity.Name,
                Price = domainEntity.Price
            };
        }
        public static implicit operator Drinks(DrinksDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Drinks()
            {
                Description = dto.Description,
                Price = dto.Price,
                Name = dto.Name,
                Image = dto.Image.FromBase64(),
                Id = dto.Id
            };
        }
    }
}
