using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFExploraSP.Vistas;

namespace WFExploraSP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #region Metodos

        /// <summary>
        /// Metodo que se encarga de llenar el formulario con controles de otro formulario
        /// </summary>
        /// <param name="frm">Formulario que se usara dentro de este otro</param>
        private void llenarPanel(Form frm)
        {
            /*Valida que la clase Form no sea nula*/
            if (frm != null)
            {
                /*Si tiene agun control los elimina*/
                if (pnlContenedor.Controls.Count > 0) { pnlContenedor.Controls.RemoveAt(0); }

                /*Realiza la configuracion para llenar el panel con controles de otro Formulario*/
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(frm);
                pnlContenedor.Tag = frm;
                frm.Show();
            }
        }

        #endregion
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnConexionBD_Click(object sender, EventArgs e)
        {
            llenarPanel(new FrmConexionBD());
        }

        private void btnAnalizaSp_Click(object sender, EventArgs e)
        {
            llenarPanel(new FrmAnalisisSp());
        }

        private void btnGeneraScript_Click(object sender, EventArgs e)
        {
            llenarPanel(new FrmGeneraScripts());
        }
    }
}
