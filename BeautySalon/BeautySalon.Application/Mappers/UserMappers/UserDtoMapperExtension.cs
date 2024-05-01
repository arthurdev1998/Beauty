using BeautySalon.Domain.Dtos;
using BeautySalon.Domain.Entities;

namespace BeautySalon.Application.Mappers.UserMappers;

public static class UserDtoMapperExtension
{
    public static UsuarioDto MapToUsuarioDto(this User src)
    {
        return new UsuarioDto()
        {
            Id = src.Id,
            Name = src.Nome,
            Email = src.Email,
        };
    }

    public static List<UsuarioDto> MapToUsuarioDto(this ICollection<User> src)
    {
        return src.Select(MapToUsuarioDto).ToList();
    }
}