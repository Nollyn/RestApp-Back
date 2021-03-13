using Rest.Domain.Entities;
using Rest.Models.Base;

namespace Rest.Models
{
    public class RestaurantsDto: BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string NIF { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public static implicit operator RestaurantsDto(Restaurants domainEntity)
        {
            if (domainEntity == null)
            {
                return null;
            }
            return new RestaurantsDto()
            {
                Description = domainEntity.Description,
                Id = domainEntity.Id,
                Name = domainEntity.Name,
                Address = domainEntity.Address,
                Phone = domainEntity.Phone,
                NIF = domainEntity.NIF,
                PostalCode = domainEntity.PostalCode,
                City = domainEntity.City,
                Country = domainEntity.Country
            };
        }
        public static implicit operator Restaurants(RestaurantsDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new Restaurants()
            {
                Description = dto.Description,
                Name = dto.Name,
                Id = dto.Id,
                Address = dto.Address,
                Phone = dto.Phone,
                NIF = dto.NIF,
                PostalCode = dto.PostalCode,
                City = dto.City,
                Country = dto.Country
            };
        }

    }
}
