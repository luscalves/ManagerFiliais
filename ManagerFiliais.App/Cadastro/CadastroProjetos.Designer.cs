using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ManagerFiliais.App.Cadastros
{
    partial class CadastroProjetos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProjetos));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboDepartamento = new ReaLTaiizor.Controls.MaterialComboBox();
            dtpDataInicio = new DateTimePicker();
            dtpDataFim = new DateTimePicker();
            DataInicioTxt = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox1 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.Images.SetKeyName(0, "form.png");
            imageList.Images.SetKeyName(1, "search.png");
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 85);
            tabControlCadastro.Margin = new Padding(3, 4, 3, 4);
            tabControlCadastro.Size = new Size(846, 400);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialMaskedTextBox1);
            tabPageCadastro.Controls.Add(DataInicioTxt);
            tabPageCadastro.Controls.Add(dtpDataFim);
            tabPageCadastro.Controls.Add(dtpDataInicio);
            tabPageCadastro.Controls.Add(cboDepartamento);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(838, 365);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboDepartamento, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpDataInicio, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpDataFim, 0);
            tabPageCadastro.Controls.SetChildIndex(DataInicioTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(materialMaskedTextBox1, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(16, 8);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(695, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(733, 8);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(102, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboDepartamento
            // 
            cboDepartamento.AutoResize = false;
            cboDepartamento.BackColor = Color.FromArgb(255, 255, 255);
            cboDepartamento.Depth = 0;
            cboDepartamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboDepartamento.DropDownHeight = 174;
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.DropDownWidth = 121;
            cboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboDepartamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Hint = "Departamento";
            cboDepartamento.IntegralHeight = false;
            cboDepartamento.ItemHeight = 43;
            cboDepartamento.Location = new Point(16, 80);
            cboDepartamento.Margin = new Padding(3, 4, 3, 4);
            cboDepartamento.MaxDropDownItems = 4;
            cboDepartamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(815, 49);
            cboDepartamento.StartIndex = 0;
            cboDepartamento.TabIndex = 2;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(16, 201);
            dtpDataInicio.Margin = new Padding(3, 4, 3, 4);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(228, 27);
            dtpDataInicio.TabIndex = 3;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Location = new Point(462, 201);
            dtpDataFim.Margin = new Padding(3, 4, 3, 4);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(228, 27);
            dtpDataFim.TabIndex = 4;
            // 
            // DataInicioTxt
            // 
            DataInicioTxt.AllowPromptAsInput = true;
            DataInicioTxt.AnimateReadOnly = false;
            DataInicioTxt.AsciiOnly = false;
            DataInicioTxt.BackgroundImageLayout = ImageLayout.None;
            DataInicioTxt.BeepOnError = false;
            DataInicioTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            DataInicioTxt.Depth = 0;
            DataInicioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DataInicioTxt.HidePromptOnLeave = false;
            DataInicioTxt.HideSelection = true;
            DataInicioTxt.InsertKeyMode = InsertKeyMode.Default;
            DataInicioTxt.LeadingIcon = null;
            DataInicioTxt.Location = new Point(16, 146);
            DataInicioTxt.Mask = "";
            DataInicioTxt.MaxLength = 32767;
            DataInicioTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DataInicioTxt.Name = "DataInicioTxt";
            DataInicioTxt.PasswordChar = '\0';
            DataInicioTxt.PrefixSuffixText = null;
            DataInicioTxt.PromptChar = '_';
            DataInicioTxt.ReadOnly = true;
            DataInicioTxt.RejectInputOnFirstFailure = false;
            DataInicioTxt.ResetOnPrompt = true;
            DataInicioTxt.ResetOnSpace = true;
            DataInicioTxt.RightToLeft = RightToLeft.No;
            DataInicioTxt.SelectedText = "";
            DataInicioTxt.SelectionLength = 0;
            DataInicioTxt.SelectionStart = 0;
            DataInicioTxt.ShortcutsEnabled = true;
            DataInicioTxt.Size = new Size(312, 48);
            DataInicioTxt.SkipLiterals = true;
            DataInicioTxt.TabIndex = 5;
            DataInicioTxt.TabStop = false;
            DataInicioTxt.Text = "Data de inicio do projeto";
            DataInicioTxt.TextAlign = HorizontalAlignment.Left;
            DataInicioTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
            DataInicioTxt.TrailingIcon = null;
            DataInicioTxt.UseSystemPasswordChar = false;
            DataInicioTxt.ValidatingType = null;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(462, 146);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = true;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(312, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 6;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.Text = "Data final para entrega do Projeto";
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // CadastroProjetos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 489);
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroProjetos";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Cadastro de Projetos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboDepartamento;
        private DateTimePicker dtpDataInicio;
        private DateTimePicker dtpDataFim;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox DataInicioTxt;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
    }
}