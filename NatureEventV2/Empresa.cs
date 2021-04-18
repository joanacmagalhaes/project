using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatureEventV2
{
    public class Empresa
    {
        private int idEmpresa;
        private string nombre;
        private string cif;
        private string email;
        private string pwd;
        private string direccion;
        private int telefono;

        public Empresa() { 
        
        }

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cif { get => cif; set => cif = value; }
        public string Email { get => email; set => email = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}