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
    public partial class CadastroFuncionarios : CadastroBase
    {
        private readonly IBaseService<Funcionarios> _funcionarioService;
        private readonly IBaseService<Filiais> _filialService;

        private List<FuncionariosModel>? funcionarios;

        public CadastroFuncionarios(IBaseService<Funcionarios> funcionarioService, IBaseService<Filiais> filialService)
        {
            _funcionarioService = funcionarioService;
            _filialService = filialService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboFilial.ValueMember = "Id";
            cboFilial.DisplayMember = "Nome";
            cboFilial.DataSource = _filialService.Get<FiliaisModel>().ToList();
        }

        private void PreencheObjeto(Funcionarios funcionario)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Cargo = txtCargo.Text;

            if (int.TryParse(cboFilial.SelectedValue.ToString(), out int idFilial))
            {
                funcionario.IdFilial = idFilial;
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
                        var funcionario = _funcionarioService.GetById<Funcionarios>(id);
                        PreencheObjeto(funcionario);
                        funcionario = _funcionarioService.Update<Funcionarios, Funcionarios, FuncionariosValidator>(funcionario);
                    }
                }
                else
                {
                    var funcionario = new Funcionarios();
                    PreencheObjeto(funcionario);
                    _funcionarioService.Add<Funcionarios, Funcionarios, FuncionariosValidator>(funcionario);
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
                _funcionarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            funcionarios = _funcionarioService.Get<FuncionariosModel>(false, new[] { "Filial" }).ToList();
            dataGridViewConsulta.DataSource = funcionarios;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtCargo.Text = linha?.Cells["Cargo"].Value.ToString();
            cboFilial.SelectedValue = linha?.Cells["IdFilial"].Value;
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