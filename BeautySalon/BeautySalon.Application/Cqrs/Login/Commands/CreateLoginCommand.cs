using System.ComponentModel.DataAnnotations;
using BeautySalon.Domain.Dtos;
using MediatR;

namespace BeautySalon.Application.Cqrs.Login.Commands;

public class CreateLoginCommand : IRequest<UsuarioDto>
{
    [Required(ErrorMessage = "Email nao pode ser nulo")]
    public required string? Email { get; set; }

    [Required(ErrorMessage = "Senha nao pode ser nula")]
    public required string? Password { get; set; }
}