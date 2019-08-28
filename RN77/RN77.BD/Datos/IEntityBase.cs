namespace RN77.BD.Datos
{
    using System;
    using RN77.BD.Datos.Entities;

    public interface IEntityBase
    {
        int Id { get; set; }
        DateTime FechaCreaReg { get; set; }
        DateTime? FechaCreaLocal { get; }
        DateTime FechaModifReg { get; set; }
        DateTime? FechaModifLocal { get; }
        DateTime FechaBajaReg { get; set; }
        DateTime? FechaBajaLocal { get; }
        string ObservReg { get; set; }
        Usuarios Usuario { get; set; }
        byte EstadoReg { get; set; }
    }
}