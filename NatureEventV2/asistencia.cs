using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatureEventV2
{
    public class asistencia
    {
        private int rIdUsuario;
        private int rIdEvento;
        private byte asistir;

        public int RIdUsuario { get => rIdUsuario; set => rIdUsuario = value; }
        public int RIdEvento { get => rIdEvento; set => rIdEvento = value; }
        public byte Asistir { get => asistir; set => asistir = value; }

        public asistencia()
        {

        }
    }
}