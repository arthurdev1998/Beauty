using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Domain.Entities;

[Table("user")]
public class User
{
    [Key, Column("cod_serial_usuario")]
    public int Id { get; set; }

    [Column("nome")]
    public string? Nome { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("passwordhash")]
    public byte[]? PasswordHash { get; set; }

    [Column("passwordsalt")]
    public byte[]? PasswordSalt { get; set; }

    [Column("createdat")]
    public DateTime CreatedAt { get; set; }

    [Column("lastupdateat")]
    public DateTime LastUpdateAt { get; set; }
}