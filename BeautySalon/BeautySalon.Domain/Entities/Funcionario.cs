using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Domain.Entities;

public class Funcionario
{
    [Column("cod_serial_funcionario")]
    public int Id { get; set; }

    [Column("cod_serial_userid")]
    public int UserId { get; set; }

    [Column("employee")]
    public ICollection<FuncionarioHabilidades>? Habilities { get; set; }

    [Column("horaentrada")]
    public int HoraEntrada { get; set; }

    [Column("horasaida")]
    public int HoraSaida { get; set; }

    [Column("active")]
    public bool IsActive { get; set; }
}