using System.ComponentModel;

namespace BeautySalon.Domain.Enums;

public enum DayWeek
{
    [Description("Domingo")]
    sunday = 0,

    [Description("Segunda")]
    monday = 1,

    [Description("Terca")]
    tuesday  = 2,

    [Description("Quarta")]
    wednesday = 3,

    [Description("Quinta")]
    thursday = 4,

    [Description("Sexta")]
    friday = 5,

    [Description("Sábado")]
    saturday = 6
}