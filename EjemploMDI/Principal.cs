using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMDI
{
    public partial class Principal : Form
    {
        //private Form1 form_1 = null;
        //private Form2 form_2 = null;

        //private Form1 FormInstance
        //{
        //    get
        //    {
        //        if (form_1 == null)
        //        {
        //            form_1 = new Form1();
        //            form_1.MdiParent = this;
        //            form_1.Load += new EventHandler(form_Load);
        //            form_1.FormClosed += new FormClosedEventHandler(form_FormClosed);
        //            form_1.Disposed += new EventHandler(form_Disposed);                   
                   
        //        }
        //        return form_1;
        //    }
        //}

        //void form_Load(object sender, EventArgs e)
        //{
        //    this.Text = "Formulario abierto";
        //}

        //void form_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    this.Text = "Se ha cerrado el Formulario";
        //}

        //void form_Disposed(object sender, EventArgs e)
        //{
        //    form_1 = null;
        //}




        public Principal()
        {
            InitializeComponent();
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            //frm.MdiParent = this;
            //frm.Show();
            //Form1 frm = this.FormInstance;
            //frm.Show();

           // Form1 objfrm1 = GenericSingleton<Form1>.GetInstance();
            Form1 objfrm1 = 
                SingletonFormProvider.GetInstance<Form1>(this);
            objfrm1.MdiParent = this;
            objfrm1.Show();

        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objfrm2 =
                SingletonFormProvider.GetInstance<Form2>(this);
            objfrm2.MdiParent = this;
            objfrm2.Show();
        }
    }
}
