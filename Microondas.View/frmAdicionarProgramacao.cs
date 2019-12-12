using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microondas.Controller;

namespace Microondas.View
{
    public partial class frmAdicionarProgramacao : Form
    {

        IMicroondasProgramavel microondasProgramavel;
        ProgramaMicroondas programaMicroondas;

        public frmAdicionarProgramacao()
        {
            InitializeComponent();
            cboAlimentos.SelectedItem = "Pudim";
        }


        public bool ShowDialogCadastrarProgramaMicroondas(IMicroondasProgramavel microondasProgramavel)
        {
            try
            {
                this.microondasProgramavel = microondasProgramavel;
                this.ShowDialog();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ShowDialogEditarProgramaMicroondas(IMicroondasProgramavel microondasProgramavel, int id)
        {
            try
            {
                this.microondasProgramavel = microondasProgramavel;
                programaMicroondas = this.microondasProgramavel.RetornarProgramacaoId(id);

                cboAlimentos.SelectedItem = programaMicroondas.Descricao;
                nudTempo.Value    = programaMicroondas.Tempo;
                nudPotencia.Value = programaMicroondas.Potencia;

                this.ShowDialog();

                return true;
            }
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (programaMicroondas is null)
                {
                    microondasProgramavel.CadastrarProgramacao(cboAlimentos.SelectedItem.ToString(), Convert.ToInt32(nudTempo.Value), Convert.ToInt32(nudPotencia.Value), txtCaractereAquecimento.Text[0]);
                }
                else
                {
                    microondasProgramavel.EditarProgramacao(programaMicroondas.Id, cboAlimentos.SelectedItem.ToString(), Convert.ToInt32(nudTempo.Value), Convert.ToInt32(nudPotencia.Value), txtCaractereAquecimento.Text[0]);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar essa operacao", "Questionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAdicionarProgramacao_Load(object sender, EventArgs e)
        {

        }

        private void txtCaractereAquecimento_Leave(object sender, EventArgs e)
        {
            if (txtCaractereAquecimento.Text == String.Empty)
                txtCaractereAquecimento.Text = "*";
        }
    }
}
