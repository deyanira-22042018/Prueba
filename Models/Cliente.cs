using System;
using System.Collections.Generic;

namespace Fibrofoto.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? NameCliente { get; set; }

    public string? ApellidoCliente { get; set; }

    public string? DireccionCliente { get; set; }

    public string? NumeroCliente { get; set; }

    public Retablo Retablo { get; set; }
}
