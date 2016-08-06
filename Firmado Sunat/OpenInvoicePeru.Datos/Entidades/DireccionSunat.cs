﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenInvoicePeru.Datos.Entidades
{
    [Table("DireccionesSunat")]
    public class DireccionSunat : TipoValorBase
    {
        [Required]
        [StringLength(50)]
        public new string Codigo { get; set; }
    }
}
