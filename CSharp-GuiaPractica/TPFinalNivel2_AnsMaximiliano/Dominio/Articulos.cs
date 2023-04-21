﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public  int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("ImágenUrl")]
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public MarcaId Marca { get; set; }
        public CategoriasId Categoria { get; set; }


    }
}
