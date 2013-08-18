using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMDI.Base.Controles
{
    public partial class ToolbarPrincipal :ToolStrip
    {
        public ToolbarPrincipal()
        {
            InitializeComponent();
        }

        public event EventHandler CrearNuevo;
        public event EventHandler ModificarActual;
        public event EventHandler EliminarActual;
        public event EventHandler Ver;
        public event EventHandler RefrescarDatos;
        public event EventHandler Aceptar;
        public event EventHandler Cancelar;
        public event EventHandler Salir;

        private EstadoBotonesToolbarPrincipal m_EstadoBotones;
        protected EstadoBotonesToolbarPrincipal EstadoBotones
        {
            get { return m_EstadoBotones; }
            set { m_EstadoBotones = value; }
        }


        private EstadoToolbarPrincipal m_Estado;
        [Category("Botonera de la aplicacion principal")]
        [Description("Obtiene o establece el estado actual del Toolbar Principal")]
        [DefaultValue(EstadoToolbarPrincipal.Ninguno)]
        public EstadoToolbarPrincipal Estado
        {
            get { return m_Estado; }
            set
            {
                m_Estado = value;

                switch (m_Estado)
                {
                    case EstadoToolbarPrincipal.Ninguno:
                        m_EstadoBotones.BotonCrear = false;
                        m_EstadoBotones.BotonModificar = false;
                        m_EstadoBotones.BotonEliminar = false;
                        m_EstadoBotones.BotonVer = false;
                        m_EstadoBotones.BotonRefrescar = false;
                        m_EstadoBotones.BotonAceptar = false;
                        m_EstadoBotones.BotonCancelar = false;
                        m_EstadoBotones.BotonSalir = false;
                        break;
                    case EstadoToolbarPrincipal.Listado:
                        m_EstadoBotones.BotonCrear = true;
                        m_EstadoBotones.BotonModificar = true;
                        m_EstadoBotones.BotonEliminar = false;
                        m_EstadoBotones.BotonVer = false;
                        m_EstadoBotones.BotonRefrescar = true;
                        m_EstadoBotones.BotonAceptar = false;
                        m_EstadoBotones.BotonCancelar = false;
                        m_EstadoBotones.BotonSalir = true;
                        break;
                    case EstadoToolbarPrincipal.CrearNuevo:
                        m_EstadoBotones.BotonCrear = false;
                        m_EstadoBotones.BotonModificar = false;
                        m_EstadoBotones.BotonEliminar = false;
                        m_EstadoBotones.BotonVer = false;
                        m_EstadoBotones.BotonRefrescar = false;
                        m_EstadoBotones.BotonAceptar = true;
                        m_EstadoBotones.BotonCancelar = true;
                        m_EstadoBotones.BotonSalir = false;
                        break;
                    case EstadoToolbarPrincipal.ModificarActual:
                        m_EstadoBotones.BotonCrear = false;
                        m_EstadoBotones.BotonModificar = false;
                        m_EstadoBotones.BotonEliminar = false;
                        m_EstadoBotones.BotonVer = false;
                        m_EstadoBotones.BotonRefrescar = false;
                        m_EstadoBotones.BotonAceptar = true;
                        m_EstadoBotones.BotonCancelar = true;
                        m_EstadoBotones.BotonSalir = false;
                        break;
                    case EstadoToolbarPrincipal.EliminarActual:
                        m_EstadoBotones.BotonCrear = false;
                        m_EstadoBotones.BotonModificar = false;
                        m_EstadoBotones.BotonEliminar = false;
                        m_EstadoBotones.BotonVer = false;
                        m_EstadoBotones.BotonRefrescar = false;
                        m_EstadoBotones.BotonAceptar = true;
                        m_EstadoBotones.BotonCancelar = true;
                        m_EstadoBotones.BotonSalir = false;
                        break;
                    case EstadoToolbarPrincipal.Ver:
                        m_EstadoBotones.BotonCrear = false;
                        m_EstadoBotones.BotonModificar = false;
                        m_EstadoBotones.BotonEliminar = false;
                        m_EstadoBotones.BotonVer = false;
                        m_EstadoBotones.BotonRefrescar = false;
                        m_EstadoBotones.BotonAceptar = false;
                        m_EstadoBotones.BotonCancelar = true;
                        m_EstadoBotones.BotonSalir = false;
                        break;
                }
                ActualizarEstadoBotones();
            }
        }



        private void ActualizarEstadoBotones()
        {
            tsbCrearNuevo.Enabled = m_EstadoBotones.BotonCrear;            
            tsbModificar.Enabled = m_EstadoBotones.BotonModificar;
            tsbEliminar.Enabled = m_EstadoBotones.BotonEliminar;
            tsbVer.Enabled = m_EstadoBotones.BotonVer;
            tsbRefrescar.Enabled = m_EstadoBotones.BotonRefrescar;
            tsbAceptar.Enabled = m_EstadoBotones.BotonAceptar;
            tsbCancelar.Enabled = m_EstadoBotones.BotonCancelar;
            tsbSalir.Enabled = m_EstadoBotones.BotonSalir;
        }


        public void ClickEnBoton(object sender, EventArgs e)
        {
            if (sender == tsbCrearNuevo)
            {
                if (CrearNuevo != null)
                {
                    CrearNuevo(this, e);
                }
            }
            else if (sender == tsbModificar)
            {
                if (ModificarActual != null)
                {
                    ModificarActual(this, e);
                }
            }
            else if (sender == tsbEliminar)
            {
                if (EliminarActual != null)
                {
                    EliminarActual(this, e);
                }
            }
            else if (sender == tsbVer)
            {
                if (Ver != null)
                {
                    Ver(this, e);
                }
            }
            else if (sender == tsbRefrescar)
            {
                if (RefrescarDatos != null)
                {
                    RefrescarDatos(this, e);
                }
            }
            else if (sender == tsbAceptar)
            {
                if (Aceptar != null)
                {
                    Aceptar(this, e);
                }
            }
            else if (sender == tsbCancelar)
            {
                if (Cancelar != null)
                {
                    Cancelar(this, e);
                }
            }
            else if (sender == tsbSalir)
            {
                if (Salir != null)
                {
                    Salir(this, e);
                }
            }
        }







    }
}
