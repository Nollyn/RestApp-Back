using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class CategoriesDto : BaseDto
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public static implicit operator CategoriesDto(Categories domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new CategoriesDto()
            {
                Description = domainEntity.Description,
                Id = domainEntity.Id,
                Name = domainEntity.Name,
            };
        }
        public static implicit operator Categories(CategoriesDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Categories()
            {
                Description = dto.Description,
                Name = dto.Name,
                Id = dto.Id,
            };
        }
    }
}
