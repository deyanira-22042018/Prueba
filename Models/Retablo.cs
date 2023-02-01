using System;
using System.Collections.Generic;

namespace Fibrofoto.Models;

public partial class Retablo
{
    public int IdRetablos { get; set; }

    public string? Descripcion { get; set; }

    public string? Tamaño { get; set; }

    public string? Price { get; set; }

    public ICollection<Cliente> Clientes { get; set; }
}
