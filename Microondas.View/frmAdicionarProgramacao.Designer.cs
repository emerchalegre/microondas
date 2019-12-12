namespace Microondas.View
{
    partial class frmAdicionarProgramacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.nudPotencia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaractereAquecimento = new System.Windows.Forms.TextBox();
            this.cboAlimentos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alimentos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo (segundos):";
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(116, 44);
            this.nudTempo.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(91, 20);
            this.nudTempo.TabIndex = 3;
            this.nudTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPotencia
            // 
            this.nudPotencia.Location = new System.Drawing.Point(116, 70);
            this.nudPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPotencia.Name = "nudPotencia";
            this.nudPotencia.Size = new System.Drawing.Size(91, 20);
            this.nudPotencia.TabIndex = 4;
            this.nudPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPotencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Potencia:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(132, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(51, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Caractere de Aquecimento:";
            // 
            // txtCaractereAquecimento
            // 
            this.txtCaractereAquecimento.Location = new System.Drawing.Point(165, 92);
            this.txtCaractereAquecimento.MaxLength = 1;
            this.txtCaractereAquecimento.Name = "txtCaractereAquecimento";
            this.txtCaractereAquecimento.Size = new System.Drawing.Size(42, 20);
            this.txtCaractereAquecimento.TabIndex = 9;
            this.txtCaractereAquecimento.Text = "*";
            this.txtCaractereAquecimento.Leave += new System.EventHandler(this.txtCaractereAquecimento_Leave);
            // 
            // cboAlimentos
            // 
            this.cboAlimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlimentos.FormattingEnabled = true;
            this.cboAlimentos.Items.AddRange(new object[] {
            "Pudim",
            "Arroz",
            "Pure",
            "Feijao",
            "Pizza",
            "Torta",
            "Leite",
            "Frango",
            "Pipoca"});
            this.cboAlimentos.Location = new System.Drawing.Point(86, 17);
            this.cboAlimentos.Name = "cboAlimentos";
            this.cboAlimentos.Size = new System.Drawing.Size(121, 21);
            this.cboAlimentos.TabIndex = 10;
            // 
            // frmAdicionarProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 156);
            this.Controls.Add(this.cboAlimentos);
            this.Controls.Add(this.txtCaractereAquecimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPotencia);
            this.Controls.Add(this.nudTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarProgramacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdicionarProgramacao";
            this.Load += new System.EventHandler(this.frmAdicionarProgramacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.NumericUpDown nudPotencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaractereAquecimento;
        private System.Windows.Forms.ComboBox cboAlimentos;
    }
}