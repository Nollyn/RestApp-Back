using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class OrdersDto : BaseDto
    {
        public string Code { get; set; }
        public decimal Amount { get; set; }

        public static implicit operator OrdersDto(Orders domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new OrdersDto()
            {
                Id = domainEntity.Id,
                Code = domainEntity.Code,
                Amount = domainEntity.Amount
            };
        }
        public static implicit operator Orders(OrdersDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Orders()
            {
                Id = dto.Id,
                Code = dto.Code,
                Amount = dto.Amount
            };
        }
    }
}
