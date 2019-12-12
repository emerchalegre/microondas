namespace Microondas.View
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTextoAquecimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTempoProcessamento = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPotenciaUtilizada = new System.Windows.Forms.NumericUpDown();
            this.txtTextoArquecido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.btnInicioNormal = new System.Windows.Forms.Button();
            this.dtgProgramacao = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbProgramacoes = new System.Windows.Forms.CheckBox();
            this.bsProgramacoes = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charAquecimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoProcessamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotenciaUtilizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProgramacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProgramacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTextoAquecimento
            // 
            this.txtTextoAquecimento.Location = new System.Drawing.Point(12, 34);
            this.txtTextoAquecimento.Multiline = true;
            this.txtTextoAquecimento.Name = "txtTextoAquecimento";
            this.txtTextoAquecimento.Size = new System.Drawing.Size(312, 52);
            this.txtTextoAquecimento.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo para processamento (em segundos):";
            // 
            // nudTempoProcessamento
            // 
            this.nudTempoProcessamento.Location = new System.Drawing.Point(222, 92);
            this.nudTempoProcessamento.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTempoProcessamento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTempoProcessamento.Name = "nudTempoProcessamento";
            this.nudTempoProcessamento.Size = new System.Drawing.Size(102, 20);
            this.nudTempoProcessamento.TabIndex = 3;
            this.nudTempoProcessamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTempoProcessamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Potencia utilizada:";
            // 
            // nudPotenciaUtilizada
            // 
            this.nudPotenciaUtilizada.Location = new System.Drawing.Point(222, 118);
            this.nudPotenciaUtilizada.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPotenciaUtilizada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPotenciaUtilizada.Name = "nudPotenciaUtilizada";
            this.nudPotenciaUtilizada.Size = new System.Drawing.Size(102, 20);
            this.nudPotenciaUtilizada.TabIndex = 5;
            this.nudPotenciaUtilizada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPotenciaUtilizada.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtTextoArquecido
            // 
            this.txtTextoArquecido.Location = new System.Drawing.Point(12, 283);
            this.txtTextoArquecido.Multiline = true;
            this.txtTextoArquecido.Name = "txtTextoArquecido";
            this.txtTextoArquecido.ReadOnly = true;
            this.txtTextoArquecido.Size = new System.Drawing.Size(312, 50);
            this.txtTextoArquecido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto para aquecimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto aquecido:";
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(235, 339);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(89, 23);
            this.btnInicioRapido.TabIndex = 8;
            this.btnInicioRapido.Text = "Inicio Rapido";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.Click += new System.EventHandler(this.btnInicioRapido_Click);
            // 
            // btnInicioNormal
            // 
            this.btnInicioNormal.Location = new System.Drawing.Point(140, 339);
            this.btnInicioNormal.Name = "btnInicioNormal";
            this.btnInicioNormal.Size = new System.Drawing.Size(89, 23);
            this.btnInicioNormal.TabIndex = 9;
            this.btnInicioNormal.Text = "Inicio Normal";
            this.btnInicioNormal.UseVisualStyleBackColor = true;
            this.btnInicioNormal.Click += new System.EventHandler(this.btnInicioNormal_Click);
            // 
            // dtgProgramacao
            // 
            this.dtgProgramacao.AllowUserToAddRows = false;
            this.dtgProgramacao.AllowUserToDeleteRows = false;
            this.dtgProgramacao.AutoGenerateColumns = false;
            this.dtgProgramacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProgramacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.tempoDataGridViewTextBoxColumn,
            this.potenciaDataGridViewTextBoxColumn,
            this.charAquecimentoDataGridViewTextBoxColumn});
            this.dtgProgramacao.DataSource = this.bsProgramacoes;
            this.dtgProgramacao.Enabled = false;
            this.dtgProgramacao.Location = new System.Drawing.Point(14, 172);
            this.dtgProgramacao.MultiSelect = false;
            this.dtgProgramacao.Name = "dtgProgramacao";
            this.dtgProgramacao.ReadOnly = true;
            this.dtgProgramacao.RowHeadersVisible = false;
            this.dtgProgramacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProgramacao.Size = new System.Drawing.Size(309, 91);
            this.dtgProgramacao.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(206, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adicionar Programacao";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ckbProgramacoes
            // 
            this.ckbProgramacoes.AutoSize = true;
            this.ckbProgramacoes.Location = new System.Drawing.Point(15, 152);
            this.ckbProgramacoes.Name = "ckbProgramacoes";
            this.ckbProgramacoes.Size = new System.Drawing.Size(155, 17);
            this.ckbProgramacoes.TabIndex = 13;
            this.ckbProgramacoes.Text = "Programacoes cadastradas";
            this.ckbProgramacoes.UseVisualStyleBackColor = true;
            this.ckbProgramacoes.CheckedChanged += new System.EventHandler(this.ckbProgramacoes_CheckedChanged);
            // 
            // bsProgramacoes
            // 
            this.bsProgramacoes.DataSource = typeof(Microondas.Controller.ProgramaMicroondas);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Alimentos";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 130;
            // 
            // tempoDataGridViewTextBoxColumn
            // 
            this.tempoDataGridViewTextBoxColumn.DataPropertyName = "Tempo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tempoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tempoDataGridViewTextBoxColumn.HeaderText = "Tempo";
            this.tempoDataGridViewTextBoxColumn.Name = "tempoDataGridViewTextBoxColumn";
            this.tempoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempoDataGridViewTextBoxColumn.Width = 60;
            // 
            // potenciaDataGridViewTextBoxColumn
            // 
            this.potenciaDataGridViewTextBoxColumn.DataPropertyName = "Potencia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.potenciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.potenciaDataGridViewTextBoxColumn.HeaderText = "Potencia";
            this.potenciaDataGridViewTextBoxColumn.Name = "potenciaDataGridViewTextBoxColumn";
            this.potenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.potenciaDataGridViewTextBoxColumn.Width = 60;
            // 
            // charAquecimentoDataGridViewTextBoxColumn
            // 
            this.charAquecimentoDataGridViewTextBoxColumn.DataPropertyName = "CharAquecimento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.charAquecimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.charAquecimentoDataGridViewTextBoxColumn.HeaderText = "Char";
            this.charAquecimentoDataGridViewTextBoxColumn.Name = "charAquecimentoDataGridViewTextBoxColumn";
            this.charAquecimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.charAquecimentoDataGridViewTextBoxColumn.Width = 50;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 374);
            this.Controls.Add(this.ckbProgramacoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgProgramacao);
            this.Controls.Add(this.btnInicioNormal);
            this.Controls.Add(this.btnInicioRapido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTextoArquecido);
            this.Controls.Add(this.nudPotenciaUtilizada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTempoProcessamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextoAquecimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microondas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoProcessamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotenciaUtilizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProgramacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProgramacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoAquecimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTempoProcessamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPotenciaUtilizada;
        private System.Windows.Forms.TextBox txtTextoArquecido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInicioRapido;
        private System.Windows.Forms.Button btnInicioNormal;
        private System.Windows.Forms.DataGridView dtgProgramacao;
        private System.Windows.Forms.BindingSource bsProgramacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbProgramacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charAquecimentoDataGridViewTextBoxColumn;
    }
}

