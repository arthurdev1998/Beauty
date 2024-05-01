using BeautySalon.Application.Cqrs.Login.Commands;
using BeautySalon.Domain.Dtos;
using BeautySalon.Domain.Entities;

namespace BeautySalon.Application.Mappers.UserMappers;

public static class UserMapperExtension
{
    public static User MapToNew(this CreateLoginCommand src)
    {
        return new User()
        {
            Email = src.Email
        };
    }
}