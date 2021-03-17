using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class OptionsDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator OptionsDto(Options domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new OptionsDto()
            {
                Description = domainEntity.Description,
                Id = domainEntity.Id,
                Name = domainEntity.Name,
            };
        }
        public static implicit operator Options(OptionsDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Options()
            {
                Description = dto.Description,
                Name = dto.Name,
                Id = dto.Id,
            };
        }
    }
}
