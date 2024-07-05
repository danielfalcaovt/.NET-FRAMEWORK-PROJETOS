namespace SistemaDeAvaliacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAvaliador = new Label();
            pnlAvaliador = new Panel();
            cbTurma = new ComboBox();
            lblNota = new Label();
            lblTbNota = new Label();
            tbNota = new TrackBar();
            lblRdTurma = new Label();
            button1 = new Button();
            label1 = new Label();
            lblTeste = new Label();
            txtAvaliador = new ComboBox();
            btnRanking = new Button();
            pnlAvaliador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbNota).BeginInit();
            SuspendLayout();
            // 
            // lblAvaliador
            // 
            lblAvaliador.Anchor = AnchorStyles.None;
            lblAvaliador.AutoSize = true;
            lblAvaliador.BackColor = Color.Transparent;
            lblAvaliador.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvaliador.ForeColor = Color.White;
            lblAvaliador.Location = new Point(200, 49);
            lblAvaliador.Name = "lblAvaliador";
            lblAvaliador.Size = new Size(384, 38);
            lblAvaliador.TabIndex = 0;
            lblAvaliador.Text = "Avaliador de Projeto";
            // 
            // pnlAvaliador
            // 
            pnlAvaliador.Anchor = AnchorStyles.None;
            pnlAvaliador.Controls.Add(cbTurma);
            pnlAvaliador.Controls.Add(lblNota);
            pnlAvaliador.Controls.Add(lblTbNota);
            pnlAvaliador.Controls.Add(tbNota);
            pnlAvaliador.Controls.Add(lblRdTurma);
            pnlAvaliador.Location = new Point(50, 100);
            pnlAvaliador.Name = "pnlAvaliador";
            pnlAvaliador.Size = new Size(700, 250);
            pnlAvaliador.TabIndex = 5;
            // 
            // cbTurma
            // 
            cbTurma.Cursor = Cursors.Hand;
            cbTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTurma.FormattingEnabled = true;
            cbTurma.Items.AddRange(new object[] { "1001", "1002", "1003", "2001", "2002", "2003", "3001", "3002", "3003" });
            cbTurma.Location = new Point(133, 119);
            cbTurma.Name = "cbTurma";
            cbTurma.Size = new Size(171, 23);
            cbTurma.TabIndex = 13;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.White;
            lblNota.Location = new Point(632, 119);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(22, 23);
            lblNota.TabIndex = 10;
            lblNota.Text = "5";
            // 
            // lblTbNota
            // 
            lblTbNota.AutoSize = true;
            lblTbNota.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            lblTbNota.ForeColor = Color.White;
            lblTbNota.Location = new Point(385, 118);
            lblTbNota.Name = "lblTbNota";
            lblTbNota.Size = new Size(178, 23);
            lblTbNota.TabIndex = 9;
            lblTbNota.Text = "Nota da Turma:";
            // 
            // tbNota
            // 
            tbNota.Cursor = Cursors.Hand;
            tbNota.Location = new Point(580, 32);
            tbNota.Name = "tbNota";
            tbNota.Orientation = Orientation.Vertical;
            tbNota.Size = new Size(45, 189);
            tbNota.TabIndex = 8;
            tbNota.Value = 5;
            tbNota.ValueChanged += tbNota_ValueChanged;
            // 
            // lblRdTurma
            // 
            lblRdTurma.AutoSize = true;
            lblRdTurma.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            lblRdTurma.ForeColor = Color.White;
            lblRdTurma.Location = new Point(27, 119);
            lblRdTurma.Name = "lblRdTurma";
            lblRdTurma.Size = new Size(87, 23);
            lblRdTurma.TabIndex = 7;
            lblRdTurma.Text = "Turma:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 227, 163);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(501, 390);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(108, 33);
            button1.TabIndex = 6;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 396);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 9;
            label1.Text = "Avaliador:";
            // 
            // lblTeste
            // 
            lblTeste.AutoSize = true;
            lblTeste.ForeColor = Color.White;
            lblTeste.Location = new Point(365, 9);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(69, 15);
            lblTeste.TabIndex = 10;
            lblTeste.Text = "RESULTADO";
            // 
            // txtAvaliador
            // 
            txtAvaliador.Cursor = Cursors.Hand;
            txtAvaliador.DropDownStyle = ComboBoxStyle.DropDownList;
            txtAvaliador.FormattingEnabled = true;
            txtAvaliador.Items.AddRange(new object[] { "Rogério", "Claudio", "Roberto", "Jucimar", "Cleidinei", "Xemberson" });
            txtAvaliador.Location = new Point(183, 396);
            txtAvaliador.Name = "txtAvaliador";
            txtAvaliador.Size = new Size(171, 23);
            txtAvaliador.TabIndex = 12;
            txtAvaliador.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnRanking
            // 
            btnRanking.BackColor = Color.Transparent;
            btnRanking.Cursor = Cursors.Hand;
            btnRanking.FlatAppearance.BorderColor = Color.White;
            btnRanking.FlatStyle = FlatStyle.Flat;
            btnRanking.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRanking.ForeColor = Color.White;
            btnRanking.Location = new Point(630, 390);
            btnRanking.Margin = new Padding(0);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(108, 33);
            btnRanking.TabIndex = 13;
            btnRanking.Text = "Ranking";
            btnRanking.UseVisualStyleBackColor = false;
            btnRanking.Click += btnRanking_Click;
            btnRanking.MouseEnter += btnRanking_MouseEnter;
            btnRanking.MouseLeave += btnRanking_MouseLeave;
            btnRanking.MouseHover += btnRanking_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 150, 231);
            ClientSize = new Size(784, 461);
            Controls.Add(lblAvaliador);
            Controls.Add(btnRanking);
            Controls.Add(txtAvaliador);
            Controls.Add(lblTeste);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pnlAvaliador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(100, 100);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Avaliador de Projeto";
            Load += Form1_Load;
            pnlAvaliador.ResumeLayout(false);
            pnlAvaliador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAvaliador;
        private Panel pnlAvaliador;
        private Label lblRdTurma;
        private Label lblTbNota;
        private TrackBar tbNota;
        private Label lblNota;
        private Button button1;
        private Label label1;
        private Label lblTeste;
        private ComboBox txtAvaliador;
        private ComboBox cbTurma;
        private Button btnRanking;
    }
}
