using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Negocios
    {
        public static string insertar(string NombreM, int EdadM)
        {
            Datos datos = new Datos();
            EntidadMaestro obj = new EntidadMaestro();
            obj.NombreM = NombreM;
            obj.EdadM = EdadM;
            return datos.insertar(obj);
        }
        public static string AgregarNotaAlumno(string NombreE, int EdadE, Decimal NotaF, string MateriaE)
        {
            Datos datos = new Datos();
            EntidadAlumno obj = new EntidadAlumno();
            obj.NombreE = NombreE;
            obj.EdadE = EdadE;
            obj.NotaF = NotaF;
            obj.Materia = MateriaE;
            return datos.AgregarNotaAlumno(obj);
        }

        public static DataTable mostrar() 
        {
            Datos datos = new Datos();
            return datos.Mostrar();
        }
    }
}
