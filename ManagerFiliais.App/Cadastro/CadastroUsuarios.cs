using ManagerFiliais.App.Base;
using ManagerFiliais.App.Models;
using ManagerFiliais.Domain.Base;
using ManagerFiliais.Domain.Entities;
using ManagerFiliais.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManagerFiliais.App.Cadastros
{
    public partial class CadastroUsuarios : CadastroBase
    {
        private readonly IBaseService<Usuarios> _usuarioService;

        private List<UsuariosModel>? usuarios;

        public CadastroUsuarios(IBaseService<Usuarios> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private void PreencheObjeto(Usuarios usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text; // Certifique-se de armazenar a senha com hash (ex: BCRYPT)
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuarios>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuarios, Usuarios, UsuariosValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuarios();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuarios, Usuarios, UsuariosValidator>(usuario);
                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<UsuariosModel>(false).ToList();
            dataGridViewConsulta.DataSource = usuarios;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Senha"]!.Visible = false;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out var id))
            {
                Deletar(id);
            }
        }
    }
}