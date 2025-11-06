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
            btnsair = new Button();
            iniciar = new Button();
            opcoes = new GroupBox();
            o = new RadioButton();
            x = new RadioButton();
            empate = new GroupBox();
            txtempates = new TextBox();
            placar = new GroupBox();
            labelO = new Label();
            labelX = new Label();
            jogadores = new GroupBox();
            jogador2 = new TextBox();
            jogador1 = new TextBox();
            btn1 = new TextBox();
            btn2 = new TextBox();
            btn3 = new TextBox();
            btn8 = new TextBox();
            btn7 = new TextBox();
            btn4 = new TextBox();
            btn5 = new TextBox();
            btn6 = new TextBox();
            btn9 = new TextBox();
            panel1.SuspendLayout();
            opcoes.SuspendLayout();
            empate.SuspendLayout();
            placar.SuspendLayout();
            jogadores.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(reiniciar);
            panel1.Controls.Add(btnsair);
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
            reiniciar.Font = new Font("Bauer", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reiniciar.ForeColor = Color.DarkCyan;
            reiniciar.Location = new Point(414, 179);
            reiniciar.Name = "reiniciar";
            reiniciar.Size = new Size(147, 36);
            reiniciar.TabIndex = 5;
            reiniciar.Text = "reiniciar";
            reiniciar.UseVisualStyleBackColor = false;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.Gainsboro;
            btnsair.Font = new Font("Bauer", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsair.ForeColor = Color.DarkCyan;
            btnsair.Location = new Point(566, 179);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(131, 36);
            btnsair.TabIndex = 4;
            btnsair.Text = "sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // iniciar
            // 
            iniciar.BackColor = Color.Gainsboro;
            iniciar.Font = new Font("Bauer", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            opcoes.Controls.Add(o);
            opcoes.Controls.Add(x);
            opcoes.Font = new Font("Bauer", 18F, FontStyle.Regular, GraphicsUnit.Point);
            opcoes.ForeColor = SystemColors.ControlLight;
            opcoes.Location = new Point(12, 141);
            opcoes.Name = "opcoes";
            opcoes.Size = new Size(176, 74);
            opcoes.TabIndex = 2;
            opcoes.TabStop = false;
            opcoes.Text = "Opções";
            // 
            // o
            // 
            o.AutoSize = true;
            o.Font = new Font("BadaBoom BB", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            o.Location = new Point(91, 24);
            o.Name = "o";
            o.Size = new Size(54, 44);
            o.TabIndex = 2;
            o.TabStop = true;
            o.Text = "O";
            o.UseVisualStyleBackColor = true;
            // 
            // x
            // 
            x.AutoSize = true;
            x.Font = new Font("BadaBoom BB", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            x.Location = new Point(28, 24);
            x.Name = "x";
            x.Size = new Size(51, 44);
            x.TabIndex = 1;
            x.TabStop = true;
            x.Text = "X";
            x.UseVisualStyleBackColor = true;
            // 
            // empate
            // 
            empate.Controls.Add(txtempates);
            empate.Font = new Font("Bauer", 18F, FontStyle.Regular, GraphicsUnit.Point);
            empate.ForeColor = SystemColors.ControlLight;
            empate.Location = new Point(521, 13);
            empate.Name = "empate";
            empate.Size = new Size(176, 122);
            empate.TabIndex = 1;
            empate.TabStop = false;
            empate.Text = "Empate";
            // 
            // txtempates
            // 
            txtempates.BackColor = Color.DarkCyan;
            txtempates.BorderStyle = BorderStyle.None;
            txtempates.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtempates.ForeColor = SystemColors.ButtonFace;
            txtempates.Location = new Point(22, 56);
            txtempates.Multiline = true;
            txtempates.Name = "txtempates";
            txtempates.Size = new Size(132, 30);
            txtempates.TabIndex = 0;
            txtempates.Text = "0";
            txtempates.TextAlign = HorizontalAlignment.Center;
            // 
            // placar
            // 
            placar.Controls.Add(labelO);
            placar.Controls.Add(labelX);
            placar.Font = new Font("Bauer", 18F, FontStyle.Regular, GraphicsUnit.Point);
            placar.ForeColor = SystemColors.ControlLight;
            placar.Location = new Point(276, 13);
            placar.Name = "placar";
            placar.Size = new Size(239, 122);
            placar.TabIndex = 1;
            placar.TabStop = false;
            placar.Text = "Placar";
            placar.Enter += placar_Enter;
            // 
            // labelO
            // 
            labelO.AutoSize = true;
            labelO.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelO.Location = new Point(19, 90);
            labelO.Name = "labelO";
            labelO.Size = new Size(40, 18);
            labelO.TabIndex = 1;
            labelO.Text = "O =";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelX.Location = new Point(19, 50);
            labelX.Name = "labelX";
            labelX.Size = new Size(44, 18);
            labelX.TabIndex = 0;
            labelX.Text = "X = ";
            // 
            // jogadores
            // 
            jogadores.Controls.Add(jogador2);
            jogadores.Controls.Add(jogador1);
            jogadores.Font = new Font("Bauer", 18F, FontStyle.Regular, GraphicsUnit.Point);
            jogadores.ForeColor = SystemColors.ControlLight;
            jogadores.Location = new Point(13, 13);
            jogadores.Name = "jogadores";
            jogadores.Size = new Size(257, 122);
            jogadores.TabIndex = 0;
            jogadores.TabStop = false;
            jogadores.Text = "Jogadores";
            // 
            // jogador2
            // 
            jogador2.BackColor = Color.Gainsboro;
            jogador2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jogador2.Location = new Point(16, 74);
            jogador2.Multiline = true;
            jogador2.Name = "jogador2";
            jogador2.Size = new Size(225, 34);
            jogador2.TabIndex = 1;
            // 
            // jogador1
            // 
            jogador1.BackColor = Color.Gainsboro;
            jogador1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            jogador1.Location = new Point(16, 34);
            jogador1.Multiline = true;
            jogador1.Name = "jogador1";
            jogador1.Size = new Size(225, 34);
            jogador1.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DarkCyan;
            btn1.BorderStyle = BorderStyle.None;
            btn1.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(234, 246);
            btn1.Multiline = true;
            btn1.Name = "btn1";
            btn1.Size = new Size(82, 64);
            btn1.TabIndex = 1;
            btn1.TextAlign = HorizontalAlignment.Center;
            btn1.Click += btn_click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DarkCyan;
            btn2.BorderStyle = BorderStyle.None;
            btn2.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(326, 246);
            btn2.Multiline = true;
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 64);
            btn2.TabIndex = 3;
            btn2.TextAlign = HorizontalAlignment.Center;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DarkCyan;
            btn3.BorderStyle = BorderStyle.None;
            btn3.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(418, 246);
            btn3.Multiline = true;
            btn3.Name = "btn3";
            btn3.Size = new Size(82, 64);
            btn3.TabIndex = 5;
            btn3.TextAlign = HorizontalAlignment.Center;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DarkCyan;
            btn8.BorderStyle = BorderStyle.None;
            btn8.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(326, 386);
            btn8.Multiline = true;
            btn8.Name = "btn8";
            btn8.Size = new Size(82, 64);
            btn8.TabIndex = 7;
            btn8.TextAlign = HorizontalAlignment.Center;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DarkCyan;
            btn7.BorderStyle = BorderStyle.None;
            btn7.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(234, 386);
            btn7.Multiline = true;
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 64);
            btn7.TabIndex = 6;
            btn7.TextAlign = HorizontalAlignment.Center;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkCyan;
            btn4.BorderStyle = BorderStyle.None;
            btn4.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(234, 316);
            btn4.Multiline = true;
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 64);
            btn4.TabIndex = 6;
            btn4.TextAlign = HorizontalAlignment.Center;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DarkCyan;
            btn5.BorderStyle = BorderStyle.None;
            btn5.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(326, 316);
            btn5.Multiline = true;
            btn5.Name = "btn5";
            btn5.Size = new Size(82, 64);
            btn5.TabIndex = 7;
            btn5.TextAlign = HorizontalAlignment.Center;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DarkCyan;
            btn6.BorderStyle = BorderStyle.None;
            btn6.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(418, 316);
            btn6.Multiline = true;
            btn6.Name = "btn6";
            btn6.Size = new Size(82, 64);
            btn6.TabIndex = 9;
            btn6.TextAlign = HorizontalAlignment.Center;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DarkCyan;
            btn9.BorderStyle = BorderStyle.None;
            btn9.Font = new Font("BadaBoom BB", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(418, 385);
            btn9.Multiline = true;
            btn9.Name = "btn9";
            btn9.Size = new Size(82, 64);
            btn9.TabIndex = 8;
            btn9.TextAlign = HorizontalAlignment.Center;
            btn9.TextChanged += textBox9_TextChanged;
            // 
            // formjogodavelha
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(709, 461);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
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
            placar.ResumeLayout(false);
            placar.PerformLayout();
            jogadores.ResumeLayout(false);
            jogadores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button reiniciar;
        private Button btnsair;
        private Button iniciar;
        private GroupBox opcoes;
        private RadioButton o;
        private RadioButton x;
        private GroupBox empate;
        private GroupBox placar;
        private GroupBox jogadores;
        private TextBox btn1;
        private TextBox btn2;
        private TextBox btn3;
        private TextBox btn8;
        private TextBox btn7;
        private TextBox btn4;
        private TextBox btn5;
        private TextBox btn6;
        private TextBox btn9;
        private TextBox jogador2;
        private TextBox jogador1;
        private TextBox txtempates;
        private Label labelO;
        private Label labelX;
    }
}