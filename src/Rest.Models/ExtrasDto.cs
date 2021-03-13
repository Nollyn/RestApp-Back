using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class ExtrasDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }

        public static implicit operator ExtrasDto(Extras domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new ExtrasDto()
            {
                Description = domainEntity.Description,
                Id = domainEntity.Id,
                Name = domainEntity.Name,
                IdCategory = domainEntity.IdCategory
            };
        }
        public static implicit operator Extras(ExtrasDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Extras()
            {
                Description = dto.Description,
                Name = dto.Name,
                Id = dto.Id,
                IdCategory = dto.IdCategory
            };
        }
    }
}
