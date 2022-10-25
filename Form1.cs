using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Tela_principal : Form
    {
        public Tela_principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check_pf_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pj.Checked && check_pf.Checked)
            {
                MessageBox.Show("Selecione somente uma caixa");
            }
            if (check_pf.Checked)
            {
                Painel_pf.Visible = true;
            }
            else 
            { 
                Painel_pf.Visible = false; 
            }
        }

        private void check_pj_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pj.Checked)
            {
                Painel_pj.Visible = true;

            }
            else
            {
                Painel_pj.Visible= false;
            }
        }
    }
}
