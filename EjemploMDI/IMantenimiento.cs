using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMDI
{
    public interface IMantenimiento
    {
        void CrearNuevo(object sender, EventArgs e);
        void ModificarActual(object sender, EventArgs e);
        void EliminarActual(object sender, EventArgs e);
        void Ver(object sender, EventArgs e);
        void RefrescarDatos(object sender, EventArgs e);
        void Aceptar(object sender, EventArgs e);
        void Cancelar(object sender, EventArgs e);
        void Salir(object sender, EventArgs e);
    }
}
