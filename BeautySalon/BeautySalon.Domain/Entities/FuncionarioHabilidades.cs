using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Domain.Entities;

public class FuncionarioHabilidades
{
    [Column("cod_serial_hability")]
    public int Id { get; set; }

    [Column("name")]
    public int HabilityName { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("timespend")]
    public int TimeSpend { get; set; }
}