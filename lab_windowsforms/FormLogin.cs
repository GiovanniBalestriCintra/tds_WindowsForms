using lab_windowsforms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_windowsforms
{
    public partial class FormLogin : Form
    {

        List<Login> usuarios = new List<Login>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            Login user1 = new Login(1, "adm01@gmail.com", "admin01", "Administrador");
            Login user2 = new Login(1, "adm02@gmail.com", "admin02", "Operador");
            Login user3 = new Login(1, "adm03@gmail.com", "admin03", "Operador");

            usuarios.Add(user1);
            usuarios.Add(user2);
            usuarios.Add(user3);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string textoLogin = this.txtLogin.Text;
            string textoSenha = this.txtSenha.Text;

            if (string.IsNullOrWhiteSpace(textoLogin))
            {
                MessageBox.Show("O login de usuário NÂO pode ser vazio!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtLogin.BackColor = Color.MistyRose;

                this.txtLogin.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(textoSenha))
            {
                MessageBox.Show("A senha de usuário NÂO pode ser vazia!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtSenha.BackColor = Color.MistyRose;


                this.txtSenha.Focus();
                return;
            }


            Login usuarioEncontrado = usuarios.FirstOrDefault
            (
                usuario => usuario.autenticar(textoLogin, textoSenha)
            );

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuário NÂO encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Bem-Vindo, {usuarioEncontrado.Nome}");

                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                frmMenu.Show();
            }

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            this.txtLogin.BackColor = Color.White;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            this.txtSenha.BackColor = Color.White;
        }
    }
}
