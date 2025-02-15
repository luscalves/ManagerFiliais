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
    public partial class CadastroFiliais : CadastroBase
    {
        private readonly IBaseService<Filiais> _filialService;
        private readonly IBaseService<Departamentos> _departamentoService;

        private List<FiliaisModel>? filiais;

        public CadastroFiliais(IBaseService<Filiais> filialService, IBaseService<Departamentos> departamentoService)
        {
            _filialService = filialService;
            _departamentoService = departamentoService;
            InitializeComponent();
        }

       
        private void PreencheObjeto(Filiais filial)
        {
            filial.Nome = txtNome.Text;
            filial.Endereco = txtEndereco.Text;
            filial.Telefone = txtTelefone.Text;

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var filial = _filialService.GetById<Filiais>(id);
                        PreencheObjeto(filial);
                        filial = _filialService.Update<Filiais, Filiais, FiliaisValidator>(filial);
                    }
                }
                else
                {
                    var filial = new Filiais();
                    PreencheObjeto(filial);
                    _filialService.Add<Filiais, Filiais, FiliaisValidator>(filial);
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
                _filialService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Manager Filiais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            filiais = _filialService.Get<FiliaisModel>(false).ToList();
            dataGridViewConsulta.DataSource = filiais;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
        }
    }
}