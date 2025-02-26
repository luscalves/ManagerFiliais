
using ManagerFiliais.App.Infra;
using ManagerFiliais.App.Outros;
using ManagerFiliais.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using ManagerFiliais.App.Cadastros;
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

        private void cadastroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuarios>();
        }

        private void cadastroDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFuncionarios>();
        }

        private void cadastroDeFiliaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFiliais>();
        }

        private void cadastroDeDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroDepartamentos>();
        }

        private void cadastroDeFuncionáriosEmPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProjetos>();
        }

        private void cadastroDeFuncionárioEmProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFuncionariosProjetos>();
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