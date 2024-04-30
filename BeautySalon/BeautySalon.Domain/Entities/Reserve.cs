using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BeautySalon.Domain.Entities;

public class Reserve
{
    [Key]
    [Column("cod_serial_reserve")]
    public int Id { get; set; }

    [Column("cod_clienteid")]
    public int ClienteId { get; set; }

    [Column("checkin")]
    public DateTime CheckIn { get; set; }

    [Column("checkout")]
    public DateTime CheckOut { get; set; }

    [Column("quantify_itens")]
    public int QtfItens { get; set; }
    public Costumer? Costumers { get; set; }

    [Column("cod_costurmer"), JsonPropertyOrder(3)]
    public int? CostumerId { get; set; }
}