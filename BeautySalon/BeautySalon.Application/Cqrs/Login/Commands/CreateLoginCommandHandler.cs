using System.Security.Cryptography;
using System.Text;
using BeautySalon.Application.Mappers.UserMappers;
using BeautySalon.Domain.Dtos;
using BeautySalon.Infraestructure.Repositories.Users;
using MediatR;

namespace BeautySalon.Application.Cqrs.Login.Commands;

public class CreateLoginCommandHandler : IRequestHandler<CreateLoginCommand, UsuarioDto>
{
    private readonly IUserRepository _userRepository;

    public CreateLoginCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UsuarioDto> Handle(CreateLoginCommand request, CancellationToken cancellationToken)
    {
        if (request.Password == null)
            throw new ArgumentNullException("usuario nao pode ser nulo");

        var entity = request.MapToNew();

        using var hmac = new HMACSHA512();
        var bytes = Encoding.UTF8.GetBytes(request.Password);
        byte[] passwordHash = hmac.ComputeHash(bytes);
        byte[] passwordSalt = hmac.Key;

        entity.PasswordHash = passwordHash;
        entity.PasswordSalt = passwordSalt;

        var registro = await _userRepository.InsertUserAsync(entity);
        return registro.MapToUsuarioDto();
    }
}