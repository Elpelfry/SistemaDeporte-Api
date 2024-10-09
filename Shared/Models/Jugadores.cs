﻿using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class Jugadores
{
    [Key]
    public int JugadorId { get; set; }
    public int EquipoId { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public char Sexo { get; set; }
}