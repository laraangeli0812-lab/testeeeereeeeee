namespace Jogo_Da_Velha
{
    public partial class formjogodavelha : Form
    {
        int X = 0, O = 0; empate
        public formjogodavelha()
        {
            InitializeComponent();
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza de que deseja sair?", "Sair do jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {

        }

        private void placar_Enter(object sender, EventArgs e)
        {

        }
    }
}