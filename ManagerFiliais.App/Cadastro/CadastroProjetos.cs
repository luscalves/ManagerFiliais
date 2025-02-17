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
    public partial class CadastroProjetos : CadastroBase
    {
        private readonly IBaseService<Projetos> _projetoService;
        private readonly IBaseService<Departamentos> _departamentoService;

        private List<ProjetosModel>? projetos;

        public CadastroProjetos(IBaseService<Projetos> projetoService, IBaseService<Departamentos> departamentoService)
        {
            _projetoService = projetoService;
            _departamentoService = departamentoService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboDepartamento.ValueMember = "Id";
            cboDepartamento.DisplayMember = "Nome";
            cboDepartamento.DataSource = _departamentoService.Get<DepartamentosModel>().ToList();
        }

        private void PreencheObjeto(Projetos projeto)
        {
            projeto.Nome = txtNome.Text;
            projeto.DataInicio = dtpDataInicio.Value;
            projeto.DataFim = dtpDataFim.Value;

            if (int.TryParse(cboDepartamento.SelectedValue.ToString(), out int idDepartamento))
            {
                projeto.IdDepartamento = idDepartamento;
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
                        var projeto = _projetoService.GetById<Projetos>(id);
                        PreencheObjeto(projeto);
                        projeto = _projetoService.Update<Projetos, Projetos, ProjetosValidator>(projeto);
                    }
                }
                else
                {
                    var projeto = new Projetos();
                    PreencheObjeto(projeto);
                    _projetoService.Add<Projetos, Projetos, ProjetosValidator>(projeto);
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
                _projetoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            projetos = _projetoService.Get<ProjetosModel>(false, new[] { "Departamento" }).ToList();
            dataGridViewConsulta.DataSource = projetos;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            dtpDataInicio.Value = DateTime.Parse(linha?.Cells["DataInicio"].Value.ToString());
            dtpDataFim.Value = DateTime.Parse(linha?.Cells["DataFim"].Value.ToString());
            cboDepartamento.SelectedValue = linha?.Cells["IdDepartamento"].Value;
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