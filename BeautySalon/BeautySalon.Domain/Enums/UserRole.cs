using System.ComponentModel;

namespace BeautySalon.Domain.Enums;

public enum UserRole
{
    [Description("Gerente")]
    Manager = 0,

    [Description("Empregado")]
    Employee = 1,

    [Description("Cliente")]
    Costumer = 2
}