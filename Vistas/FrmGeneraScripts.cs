using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFExploraSP.Vistas
{
    public partial class FrmGeneraScripts : Form
    {
        public FrmGeneraScripts()
        {
            InitializeComponent();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        #region Metodos

        public void validaPR()
        {
            int indx = txtConsulta.SelectionStart;
            txtConsulta.SelectAll();
            txtConsulta.SelectionColor = Color.Black;
            txtConsulta.SelectionFont = new Font(txtConsulta.Font, FontStyle.Regular);

            foreach (var item in WFExploraSP.Logica.EditorTexto._prOracle)
            {
                string pattern = @"(?<!['""\/])\b" + item.ToLower() + @"\b(?!['""\/])";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(txtConsulta.Text);
                // Resalta cada coincidencia de la palabra reservada en el RichTextBox
                foreach (Match match in matches)
                {
                    int startIndex = match.Index;
                    int length = match.Length;

                    txtConsulta.Select(startIndex, length);
                    txtConsulta.SelectionColor = Color.Blue;
                    txtConsulta.SelectionFont = new Font(txtConsulta.Font, FontStyle.Bold);
                    txtConsulta.DeselectAll();
                }
            }
            txtConsulta.DeselectAll();
            txtConsulta.SelectionStart = indx;
        }

        #endregion

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            validaPR();
        }
    }
}
