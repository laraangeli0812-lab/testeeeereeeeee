namespace Jogo_Da_Velha
{
    partial class formjogodavelha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formjogodavelha));
            panel1 = new Panel();
            reiniciar = new Button();
            button2 = new Button();
            iniciar = new Button();
            opcoes = new GroupBox();
            O = new RadioButton();
            x = new RadioButton();
            empate = new GroupBox();
            placar = new GroupBox();
            jogadores = new GroupBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox12 = new TextBox();
            panel1.SuspendLayout();
            opcoes.SuspendLayout();
            empate.SuspendLayout();
            jogadores.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(reiniciar);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(iniciar);
            panel1.Controls.Add(opcoes);
            panel1.Controls.Add(empate);
            panel1.Controls.Add(placar);
            panel1.Controls.Add(jogadores);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 234);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // reiniciar
            // 
            reiniciar.BackColor = Color.Gainsboro;
            reiniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reiniciar.ForeColor = Color.DarkCyan;
            reiniciar.Location = new Point(414, 179);
            reiniciar.Name = "reiniciar";
            reiniciar.Size = new Size(147, 36);
            reiniciar.TabIndex = 5;
            reiniciar.Text = "reiniciar";
            reiniciar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(566, 179);
            button2.Name = "button2";
            button2.Size = new Size(131, 36);
            button2.TabIndex = 4;
            button2.Text = "sair";
            button2.UseVisualStyleBackColor = false;
            // 
            // iniciar
            // 
            iniciar.BackColor = Color.Gainsboro;
            iniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iniciar.ForeColor = Color.DarkCyan;
            iniciar.Location = new Point(261, 179);
            iniciar.Name = "iniciar";
            iniciar.Size = new Size(147, 36);
            iniciar.TabIndex = 3;
            iniciar.Text = "iniciar";
            iniciar.UseVisualStyleBackColor = false;
            // 
            // opcoes
            // 
            opcoes.Controls.Add(O);
            opcoes.Controls.Add(x);
            opcoes.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            opcoes.ForeColor = SystemColors.ControlLight;
            opcoes.Location = new Point(12, 141);
            opcoes.Name = "opcoes";
            opcoes.Size = new Size(176, 74);
            opcoes.TabIndex = 2;
            opcoes.TabStop = false;
            opcoes.Text = "Opções";
            opcoes.Enter += opcoes_Enter;
            // 
            // O
            // 
            O.AutoSize = true;
            O.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Regular, GraphicsUnit.Point);
            O.Location = new Point(96, 32);
            O.Name = "O";
            O.Size = new Size(54, 36);
            O.TabIndex = 2;
            O.TabStop = true;
            O.Text = "O";
            O.UseVisualStyleBackColor = true;
            // 
            // x
            // 
            x.AutoSize = true;
            x.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Regular, GraphicsUnit.Point);
            x.Location = new Point(33, 32);
            x.Name = "x";
            x.Size = new Size(51, 36);
            x.TabIndex = 1;
            x.TabStop = true;
            x.Text = "X";
            x.UseVisualStyleBackColor = true;
            // 
            // empate
            // 
            empate.Controls.Add(textBox12);
            empate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            empate.ForeColor = SystemColors.ControlLight;
            empate.Location = new Point(521, 13);
            empate.Name = "empate";
            empate.Size = new Size(176, 122);
            empate.TabIndex = 1;
            empate.TabStop = false;
            empate.Text = "Empate";
            // 
            // placar
            // 
            placar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            placar.ForeColor = SystemColors.ControlLight;
            placar.Location = new Point(276, 13);
            placar.Name = "placar";
            placar.Size = new Size(239, 122);
            placar.TabIndex = 1;
            placar.TabStop = false;
            placar.Text = "Placar";
            // 
            // jogadores
            // 
            jogadores.Controls.Add(textBox11);
            jogadores.Controls.Add(textBox10);
            jogadores.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            jogadores.ForeColor = SystemColors.ControlLight;
            jogadores.Location = new Point(13, 13);
            jogadores.Name = "jogadores";
            jogadores.Size = new Size(257, 122);
            jogadores.TabIndex = 0;
            jogadores.TabStop = false;
            jogadores.Text = "Jogadores";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.Gainsboro;
            textBox11.Location = new Point(16, 74);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(225, 34);
            textBox11.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Gainsboro;
            textBox10.Location = new Point(16, 34);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(225, 34);
            textBox10.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkCyan;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(234, 246);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(82, 64);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkCyan;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(326, 246);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(82, 64);
            textBox3.TabIndex = 3;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkCyan;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(418, 246);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(82, 64);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkCyan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(326, 386);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(82, 64);
            textBox4.TabIndex = 7;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkCyan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(234, 386);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(82, 64);
            textBox5.TabIndex = 6;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DarkCyan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(234, 316);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(82, 64);
            textBox6.TabIndex = 6;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.DarkCyan;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(326, 316);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(82, 64);
            textBox7.TabIndex = 7;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.DarkCyan;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(418, 316);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(82, 64);
            textBox8.TabIndex = 9;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.DarkCyan;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(418, 385);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(82, 64);
            textBox9.TabIndex = 8;
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.DarkCyan;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Location = new Point(23, 62);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(132, 30);
            textBox12.TabIndex = 0;
            textBox12.Text = "1";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // formjogodavelha
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(709, 461);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox7);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formjogodavelha";
            Text = "Jogo Da Velha";
            panel1.ResumeLayout(false);
            opcoes.ResumeLayout(false);
            opcoes.PerformLayout();
            empate.ResumeLayout(false);
            empate.PerformLayout();
            jogadores.ResumeLayout(false);
            jogadores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button reiniciar;
        private Button button2;
        private Button iniciar;
        private GroupBox opcoes;
        private RadioButton O;
        private RadioButton x;
        private GroupBox empate;
        private GroupBox placar;
        private GroupBox jogadores;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox12;
    }
}