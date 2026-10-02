namespace login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;

            if (usuario == "")
            {
                MessageBox.Show(" Ingrese usuario: ", "Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();

                return;

            }
            if (contraseña == "")
            {
                MessageBox.Show(" Ingrese la contraseña: ", " Validacion ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();

                return;
            }
            if (usuario == "admin" && contraseña == "1234")
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();

                this.Hide();
            }

            txtPassword.Clear();
            txtPassword.Focus();
        }

      
    }
}
