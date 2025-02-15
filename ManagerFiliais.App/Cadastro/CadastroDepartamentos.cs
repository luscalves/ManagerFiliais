using ManagerFiliais.App.Base;
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
        private List<Departamentos> departamentos;
        private bool IsAlteracao;

        public CadastroDepartamentos(IBaseService<Departamentos> departamentoService)
        {
            _departamentoService = departamentoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Departamentos departamento)
        {
            departamento.Nome = txtNome.Text;
            departamento.IdFilial = int.Parse(txtIdFilial.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                CarregaGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out var id))
                {
                    _departamentoService.Delete(id);
                    MessageBox.Show("Departamento deletado com sucesso!", "Manager Filiais",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaGrid();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaGrid()
        {
            departamentos = _departamentoService.Get<Departamentos>().ToList();
            dataGridViewConsulta.DataSource = departamentos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtIdFilial.Text = linha?.Cells["IdFilial"].Value.ToString();
            IsAlteracao = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtIdFilial.Text = string.Empty;
            IsAlteracao = false;
        }

        private void CadastroDepartamentos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var linha = dataGridViewConsulta.Rows[e.RowIndex];
                CarregaRegistro(linha);
            }
        }
    }
}