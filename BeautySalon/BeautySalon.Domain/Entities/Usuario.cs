using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Domain.Entities;

public class Usuario
{
    [Column("cod_serial_usuario")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("cpf")]
    public string? Cpf { get; set; }

    [Column("passwordhash")]
    public byte[]? PasswordHash { get; set; }

    [Column("passwordsalt")]
    public byte[]? PasswordSalt { get; set; }

    [Column("createdate")]
    public DateTime CreateAt { get; set; }

    [Column("lastupdate")]
    public DateTime UpdateAt { get; set; }

    [Column("active")]
    public bool IsActive { get; set; }
}