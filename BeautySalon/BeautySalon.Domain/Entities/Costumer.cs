using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Domain.Entities;

[Table("costumer")]
public class Costumer : User
{
    [Column("cod_serial_costumer")]
    public int Id { get; set; }

    [Column("cod_serial_userid")]
    public int UserId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("phone")]
    public string? Phone { get; set; }

    [Column("cpf")]
    public string? Cpf { get; set; }

    public virtual ICollection<Reserve> Reserves { get; set; } = [];
}