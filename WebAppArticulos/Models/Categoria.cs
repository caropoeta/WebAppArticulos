﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppArticulos.Models
{
    public class Categoria
    {

        public long CategoriaID { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public int Eliminado { get; set; }

        public List<Producto> Producto { get; set; }

    }
}
