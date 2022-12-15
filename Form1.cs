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
        List<Fisica> ListFisica = new List<Fisica>();// criação de list fisica

        List<Juridica> ListJuridica = new List<Juridica>();//criação de list juridica
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

        private void BtnExibir_Click(object sender, EventArgs e)
        {
          List <Fisica> listFisica = new List <Fisica>();
            for (int i = 0; i <listFisica.Count; i++)
            {
                if (Tbx_nome.Text.Equals(listFisica[i].Nome))
                {
                    MessageBox.Show("Nome: " + listFisica[i].Nome + "\nEndereço: " + listFisica[i].Endereco + "\nEmail: " + listFisica[i].Email + "\nTelefone"
               + listFisica[i].Telefone + "\nCPF: " + listFisica[i].Cpf + "\nData de nacimento: " + listFisica[i].Data_nascimento);
                }
               
            }
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if (check_pf.Checked)
            {
                
                Fisica Objfisica = new Fisica(Tbx_nome.Text, Tbx_ende.Text, Mask_tel.Text,Txb_email.Text,Mask_cpf.Text,Mask_data.Text);
                ListFisica.Add(Objfisica);
                MessageBox.Show("Dados de pessoa física cadastrados com sucesso", "Mensagem",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Juridica objjuridica = new Juridica(Tbx_nome.Text, Tbx_ende.Text, Mask_tel.Text, Txb_email.Text, Tbx_fantasia.Text, Mask_cnpj.Text);
                ListJuridica.Add(objjuridica);
                MessageBox.Show("Dados de pessoa jurídica cadastrados com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
