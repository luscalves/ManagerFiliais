using ManagerFiliais.Domain.Entities;
using ManagerFiliais.Service.Validators;
using ReaLTaiizor.Forms;
using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Usuarios> _usuarioService;
        public Login(IBaseService<Usuarios> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Usuarios usuario = ObterUsuario(txtUsuario.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválida!", "Manager Filiais",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                else
            {
                usuario = _usuarioService.Update<Usuarios, Usuarios, UsuariosValidator>(usuario);
                FormPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private Usuarios? ObterUsuario(string nome, string senha)
        {
            ChecaExistenciaDeUsuarioCadastrado();
            var usuario = _usuarioService.Get<Usuarios>().Where(x => x.Nome == nome).FirstOrDefault();
            if (usuario == null)
                return null;
            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaDeUsuarioCadastrado()
        {
            var usuarios = _usuarioService.Get<Usuarios>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuarios
                {
                 
                    Nome = "lucalves14",
                    Email = "admin@gmail.com",
                    Senha = "admin"
                };
                _usuarioService.Add<Usuarios, Usuarios, UsuariosValidator>(usuario);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}