using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;

namespace RN77.BD.Controllers
{
    public static class BaseController
    {

        public static void CompletaRegistro(IEntityBase entity, byte estadoregistro, string observacion, Usuarios usuario, bool esBaja )
        {
            entity.EstadoReg = estadoregistro;
            entity.ObservReg = observacion;
            entity.Usuario = usuario;
            if (!esBaja)
            {
                entity.FechaCreaReg = DateTime.UtcNow;
            }
            entity.FechaModifReg = DateTime.UtcNow;
            if (esBaja)
            {
                entity.FechaBajaReg = DateTime.UtcNow;
            }
        }
    }
}
