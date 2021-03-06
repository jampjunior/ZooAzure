﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooAzure
{
    public class Especies
    {
        public long idEspecie { get; set; }
        public long idClasificacion { get; set; }
        public long idTipoAnimal { get; set; }
        public string nombre { get; set; }
        public Int16 nPatas { get; set; }
        public Boolean esMascota { get; set; }
        public Clasificacion clasificacion { get; set; }
        public TiposAnimales tipoAnimales { get; set; }


    }
}