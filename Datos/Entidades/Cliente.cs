﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public List<Renta> Rentas { get; set; } = new List<Renta>();


    }
}
