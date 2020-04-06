using ContactManager.Domain.Entities;
using ContactManager.Dtos;
using System.Collections.Generic;

namespace ContactManager.Services.Extensions
{
    /// <summary>
    /// The idea of using extensions is because it's a simple scope. Maybe we can consider using AutoMapper, for example
    /// but the idea is the same, just expose the Dto for UI/contact... and work with entities/models in lower layers (repository)
    /// </summary>
    public static class MappingExtensions
    {
        public static Customer ToCustomerEntity(this ContactDto dto)
        {
            return new Customer
            {
                Id = dto.Id,
                Name = dto.Name,
                Email = dto.Email,
                Birthday = dto.BirthDate
            };
        }

        public static Supplier ToSupplierEntity(this ContactDto dto)
        {
            return new Supplier
            {
                Id = dto.Id,
                Name = dto.Name,
                PhoneNumber = dto.Phone
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static ContactDto ToDto(this Contact entity)
        {
            if (entity is Customer)
            {
                return new ContactDto
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    BirthDate = (entity as Customer).Birthday,
                    Email = (entity as Customer).Email,
                    IsCustomer = true
                };
            }

            return new ContactDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Phone = (entity as Supplier).PhoneNumber,
                IsCustomer = false
            };
        }

        public static IEnumerable<ContactDto> ToDto(this IEnumerable<Contact> entities)
        {
            var contactsDto = new List<ContactDto>();

            foreach (var item in entities)
            {
                contactsDto.Add(item.ToDto());
            }

            return contactsDto;
        }
    }
}
