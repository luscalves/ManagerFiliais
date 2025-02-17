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
    public partial class CadastroFuncionariosProjetos : CadastroBase
    {
        private readonly IBaseService<FuncionariosProjetos> _funcionarioProjetoService;
        private readonly IBaseService<Funcionarios> _funcionarioService;
        private readonly IBaseService<Projetos> _projetoService;

        private List<FuncionariosProjetosModel>? funcionariosProjetos;

        public CadastroFuncionariosProjetos(IBaseService<FuncionariosProjetos> funcionarioProjetoService, IBaseService<Funcionarios> funcionarioService, IBaseService<Projetos> projetoService)
        {
            _funcionarioProjetoService = funcionarioProjetoService;
            _funcionarioService = funcionarioService;
            _projetoService = projetoService;
            InitializeComponent();
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            cboFuncionario.ValueMember = "Id";
            cboFuncionario.DisplayMember = "Nome";
            cboFuncionario.DataSource = _funcionarioService.Get<FuncionariosModel>().ToList();

            cboProjeto.ValueMember = "Id";
            cboProjeto.DisplayMember = "Nome";
            cboProjeto.DataSource = _projetoService.Get<ProjetosModel>().ToList();
        }

        private void PreencheObjeto(FuncionariosProjetos funcionarioProjeto)
        {
            funcionarioProjeto.CargoProjeto = txtCargoProjeto.Text;
            funcionarioProjeto.DataParticipacao = dtpDataParticipacao.Value;

            if (int.TryParse(cboFuncionario.SelectedValue.ToString(), out int idFuncionario))
            {
                funcionarioProjeto.IdFuncionario = idFuncionario;
            }

            if (int.TryParse(cboProjeto.SelectedValue.ToString(), out int idProjeto))
            {
                funcionarioProjeto.IdProjeto = idProjeto;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var funcionarioProjeto = _funcionarioProjetoService.GetById<FuncionariosProjetos>(id);
                        PreencheObjeto(funcionarioProjeto);
                        funcionarioProjeto = _funcionarioProjetoService.Update<FuncionariosProjetos, FuncionariosProjetos, FuncionariosProjetosValidator>(funcionarioProjeto);
                    }
                }
                else
                {
                    var funcionarioProjeto = new FuncionariosProjetos();
                    PreencheObjeto(funcionarioProjeto);
                    _funcionarioProjetoService.Add<FuncionariosProjetos, FuncionariosProjetos, FuncionariosProjetosValidator>(funcionarioProjeto);
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
                _funcionarioProjetoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcionariosProjetos = _funcionarioProjetoService.Get<FuncionariosProjetosModel>(false, new[] { "Funcionario", "Projeto" }).ToList();
            dataGridViewConsulta.DataSource = funcionariosProjetos;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["CargoProjeto"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtCargoProjeto.Text = linha?.Cells["CargoProjeto"].Value.ToString();
            dtpDataParticipacao.Value = DateTime.Parse(linha?.Cells["DataParticipacao"].Value.ToString());
            cboFuncionario.SelectedValue = linha?.Cells["IdFuncionario"].Value;
            cboProjeto.SelectedValue = linha?.Cells["IdProjeto"].Value;
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