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
    public partial class CadastroDepartamentos : CadastroBase
    {
        private readonly IBaseService<Departamentos> _departamentoService;
        private readonly IBaseService<Filiais> _filialService;

        private List<DepartamentosModel>? departamentos;

        public CadastroDepartamentos(IBaseService<Departamentos> departamentoService, IBaseService<Filiais> filialService)
        {
            _departamentoService = departamentoService;
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

        private void PreencheObjeto(Departamentos departamento)
        {
            departamento.Nome = txtNome.Text;

            if (int.TryParse(cboFilial.SelectedValue.ToString(), out int idFilial))
            {
                departamento.IdFilial = idFilial;
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
                        var departamento = _departamentoService.GetById<Departamentos>(id);
                        PreencheObjeto(departamento);
                        departamento = _departamentoService.Update<Departamentos, Departamentos, DepartamentosValidator>(departamento);
                    }
                }
                else
                {
                    var departamento = new Departamentos();
                    PreencheObjeto(departamento);
                    _departamentoService.Add<Departamentos, Departamentos, DepartamentosValidator>(departamento);
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
                _departamentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            departamentos = _departamentoService.Get<DepartamentosModel>(false, new[] { "Filial" }).ToList();
            dataGridViewConsulta.DataSource = departamentos;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
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