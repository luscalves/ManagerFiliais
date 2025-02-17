namespace ManagerFiliais.App.Cadastros
{
    partial class CadastroFuncionariosProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionariosProjetos));
            txtCargoProjeto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboFuncionario = new ReaLTaiizor.Controls.MaterialComboBox();
            cboProjeto = new ReaLTaiizor.Controls.MaterialComboBox();
            dtpDataParticipacao = new DateTimePicker();
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
            tabControlCadastro.Size = new Size(838, 379);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(dtpDataParticipacao);
            tabPageCadastro.Controls.Add(cboProjeto);
            tabPageCadastro.Controls.Add(cboFuncionario);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtCargoProjeto);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(830, 344);
            tabPageCadastro.Controls.SetChildIndex(txtCargoProjeto, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFuncionario, 0);
            tabPageCadastro.Controls.SetChildIndex(cboProjeto, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpDataParticipacao, 0);
            // 
            // txtCargoProjeto
            // 
            txtCargoProjeto.AnimateReadOnly = false;
            txtCargoProjeto.AutoCompleteMode = AutoCompleteMode.None;
            txtCargoProjeto.AutoCompleteSource = AutoCompleteSource.None;
            txtCargoProjeto.BackgroundImageLayout = ImageLayout.None;
            txtCargoProjeto.CharacterCasing = CharacterCasing.Normal;
            txtCargoProjeto.Depth = 0;
            txtCargoProjeto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCargoProjeto.HideSelection = true;
            txtCargoProjeto.Hint = "Cargo no Projeto";
            txtCargoProjeto.LeadingIcon = null;
            txtCargoProjeto.Location = new Point(16, 8);
            txtCargoProjeto.Margin = new Padding(3, 4, 3, 4);
            txtCargoProjeto.MaxLength = 32767;
            txtCargoProjeto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCargoProjeto.Name = "txtCargoProjeto";
            txtCargoProjeto.PasswordChar = '\0';
            txtCargoProjeto.PrefixSuffixText = null;
            txtCargoProjeto.ReadOnly = false;
            txtCargoProjeto.RightToLeft = RightToLeft.No;
            txtCargoProjeto.SelectedText = "";
            txtCargoProjeto.SelectionLength = 0;
            txtCargoProjeto.SelectionStart = 0;
            txtCargoProjeto.ShortcutsEnabled = true;
            txtCargoProjeto.Size = new Size(641, 48);
            txtCargoProjeto.TabIndex = 0;
            txtCargoProjeto.TabStop = false;
            txtCargoProjeto.TextAlign = HorizontalAlignment.Left;
            txtCargoProjeto.TrailingIcon = null;
            txtCargoProjeto.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(677, 8);
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
            txtId.Size = new Size(124, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboFuncionario
            // 
            cboFuncionario.AutoResize = false;
            cboFuncionario.BackColor = Color.FromArgb(255, 255, 255);
            cboFuncionario.Depth = 0;
            cboFuncionario.DrawMode = DrawMode.OwnerDrawVariable;
            cboFuncionario.DropDownHeight = 174;
            cboFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncionario.DropDownWidth = 121;
            cboFuncionario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFuncionario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFuncionario.FormattingEnabled = true;
            cboFuncionario.Hint = "Funcionário";
            cboFuncionario.IntegralHeight = false;
            cboFuncionario.ItemHeight = 43;
            cboFuncionario.Location = new Point(16, 80);
            cboFuncionario.Margin = new Padding(3, 4, 3, 4);
            cboFuncionario.MaxDropDownItems = 4;
            cboFuncionario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFuncionario.Name = "cboFuncionario";
            cboFuncionario.Size = new Size(785, 49);
            cboFuncionario.StartIndex = 0;
            cboFuncionario.TabIndex = 2;
            // 
            // cboProjeto
            // 
            cboProjeto.AutoResize = false;
            cboProjeto.BackColor = Color.FromArgb(255, 255, 255);
            cboProjeto.Depth = 0;
            cboProjeto.DrawMode = DrawMode.OwnerDrawVariable;
            cboProjeto.DropDownHeight = 174;
            cboProjeto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProjeto.DropDownWidth = 121;
            cboProjeto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProjeto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProjeto.FormattingEnabled = true;
            cboProjeto.Hint = "Projeto";
            cboProjeto.IntegralHeight = false;
            cboProjeto.ItemHeight = 43;
            cboProjeto.Location = new Point(16, 153);
            cboProjeto.Margin = new Padding(3, 4, 3, 4);
            cboProjeto.MaxDropDownItems = 4;
            cboProjeto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProjeto.Name = "cboProjeto";
            cboProjeto.Size = new Size(785, 49);
            cboProjeto.StartIndex = 0;
            cboProjeto.TabIndex = 3;
            // 
            // dtpDataParticipacao
            // 
            dtpDataParticipacao.Location = new Point(33, 256);
            dtpDataParticipacao.Margin = new Padding(3, 4, 3, 4);
            dtpDataParticipacao.Name = "dtpDataParticipacao";
            dtpDataParticipacao.Size = new Size(228, 27);
            dtpDataParticipacao.TabIndex = 4;
            // 
            // CadastroFuncionariosProjetos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 468);
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroFuncionariosProjetos";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Cadastro de Funcionários em Projetos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCargoProjeto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboFuncionario;
        private ReaLTaiizor.Controls.MaterialComboBox cboProjeto;
        private DateTimePicker dtpDataParticipacao;
    }
}