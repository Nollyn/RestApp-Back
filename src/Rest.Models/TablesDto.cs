using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class TablesDto : BaseDto
    {
        public string Code { get; set; }
        public string QR { get; set; }
        public int IdRestaurant { get; set; }

        public static implicit operator TablesDto(Tables domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new TablesDto()
            {
                Code = domainEntity.Code,
                Id = domainEntity.Id,
                QR = domainEntity.QR,
                IdRestaurant = domainEntity.IdRestaurant
            };
        }
        public static implicit operator Tables(TablesDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Tables()
            {
                Code = dto.Code,
                QR = dto.QR,
                Id = dto.Id,
                IdRestaurant = dto.IdRestaurant
            };
        }
    }
}
