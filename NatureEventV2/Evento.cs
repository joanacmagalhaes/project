using System;

namespace NatureEventV2
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int RIdEmpresa { get; set; }
        public int Puntos { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public Double PosX { get; set; }
        public Double PosY { get; set; }

        public string NombreEmpresa { get; set; }


        public override string ToString()
        {
            return Nombre + " - " + Puntos + "\n" + Descripcion + "\n" + Direccion + "\n" + FechaInicio + " - " + FechaFinal;
        }
    }
}