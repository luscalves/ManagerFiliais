
using ManagerFiliais.App.Infra;
using ManagerFiliais.App.Outros;
using ManagerFiliais.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using ManagerFiliais.App.Cadastro;
using ManagerFiliais.App.Cadastros;

namespace ManagerFiliais.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuarios Usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUsuario.Text = $"Usuário: {Usuario.Nome}";
                }
            }
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFiliais>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFuncionarios>();
        }

        private void grupoDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuarios>();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroDepartamentos>();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFuncionariosProjetos>();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProjetos>();
        }

    
        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}