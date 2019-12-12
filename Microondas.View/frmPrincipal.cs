using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;

namespace Microondas.View
{
    public partial class frmPrincipal : Form
    {
        Controller.Microondas microondasController = new Controller.Microondas();
        BindingListView<Controller.ProgramaMicroondas> blvProgramaMicroOndas;

        public frmPrincipal()
        {
            InitializeComponent();
            blvProgramaMicroOndas = new BindingListView<Controller.ProgramaMicroondas>(microondasController.ListarProgramacao());
            bsProgramacoes.DataSource = blvProgramaMicroOndas;
        }

        private void btnInicioNormal_Click(object sender, EventArgs e)
        {
            try
            {
                if (ckbProgramacoes.Checked && !(bsProgramacoes.Current is null))
                {
                    ObjectView<Controller.ProgramaMicroondas> vProgramaMicroondas = (ObjectView<Controller.ProgramaMicroondas>) bsProgramacoes.Current;

                    txtTextoArquecido.Text = microondasController.AquecerStringProgramacao(txtTextoAquecimento.Text, vProgramaMicroondas.Object.Id);
                }
                else {
                    int tempo = Convert.ToInt32(nudTempoProcessamento.Value),
                        potencia = Convert.ToInt32(nudPotenciaUtilizada.Value);

                    txtTextoArquecido.Text = microondasController.AquecerString(txtTextoAquecimento.Text, tempo, potencia);

                    
                }

                MessageBox.Show("Texto Aquecido", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdicionarProgramacao frmAdicionarProgramacao = new frmAdicionarProgramacao();
                frmAdicionarProgramacao.ShowDialogCadastrarProgramaMicroondas(microondasController);
                blvProgramaMicroOndas.DataSource = microondasController.ListarProgramacao();
                blvProgramaMicroOndas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, contate o desenvolvedor: " + ex.ToString());
            }
        }

        private void ckbProgramacoes_CheckedChanged(object sender, EventArgs e)
        {
            dtgProgramacao.Enabled = ckbProgramacoes.Checked;
            nudTempoProcessamento.Enabled = !ckbProgramacoes.Checked;
            nudPotenciaUtilizada.Enabled = !ckbProgramacoes.Checked;
        }

        private void btnInicioRapido_Click(object sender, EventArgs e)
        {
            try
            {
                nudTempoProcessamento.Value = 8;
                nudPotenciaUtilizada.Value = 10;

                txtTextoArquecido.Text = microondasController.AquecerString(txtTextoAquecimento.Text, 8, 10);

                MessageBox.Show("Texto Aquecido", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
