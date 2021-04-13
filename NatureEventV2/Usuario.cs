using System;

namespace NatureEventV2
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string apellido;
        private string email;
        private string pwd;
        private string dni;
        private DateTime? fechaNac;
        private string direccion;
        private int? telefono;
        private int? puntos;

        public Usuario() { 
            
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime? FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int? Telefono { get => telefono; set => telefono = value; }
        public int? Puntos { get => puntos; set => puntos = value; }


    }
}