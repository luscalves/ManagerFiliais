namespace ManagerFiliais.App.Cadastros
{
    partial class CadastroDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDepartamentos));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdFilial = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            IdTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            DepartamentoTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabControlCadastro.Size = new Size(531, 336);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(DepartamentoTxt);
            tabPageCadastro.Controls.Add(IdTxt);
            tabPageCadastro.Size = new Size(523, 301);
            tabPageCadastro.Controls.SetChildIndex(IdTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(DepartamentoTxt, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(112, 78);
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
            txtNome.Size = new Size(326, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtIdFilial
            // 
            txtIdFilial.AnimateReadOnly = false;
            txtIdFilial.AutoCompleteMode = AutoCompleteMode.None;
            txtIdFilial.AutoCompleteSource = AutoCompleteSource.None;
            txtIdFilial.BackgroundImageLayout = ImageLayout.None;
            txtIdFilial.CharacterCasing = CharacterCasing.Normal;
            txtIdFilial.Depth = 0;
            txtIdFilial.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdFilial.HideSelection = true;
            txtIdFilial.Hint = "ID Filial";
            txtIdFilial.LeadingIcon = null;
            txtIdFilial.Location = new Point(457, 78);
            txtIdFilial.MaxLength = 32767;
            txtIdFilial.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIdFilial.Name = "txtIdFilial";
            txtIdFilial.PasswordChar = '\0';
            txtIdFilial.PrefixSuffixText = null;
            txtIdFilial.ReadOnly = false;
            txtIdFilial.RightToLeft = RightToLeft.No;
            txtIdFilial.SelectedText = "";
            txtIdFilial.SelectionLength = 0;
            txtIdFilial.SelectionStart = 0;
            txtIdFilial.ShortcutsEnabled = true;
            txtIdFilial.Size = new Size(151, 48);
            txtIdFilial.TabIndex = 2;
            txtIdFilial.TabStop = false;
            txtIdFilial.TextAlign = HorizontalAlignment.Left;
            txtIdFilial.TrailingIcon = null;
            txtIdFilial.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(6, 78);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(92, 48);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(329, 179);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(120, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Salvar";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDelete.Location = new Point(474, 179);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(120, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Deletar";
            btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // IdTxt
            // 
            IdTxt.AnimateReadOnly = false;
            IdTxt.AutoCompleteMode = AutoCompleteMode.None;
            IdTxt.AutoCompleteSource = AutoCompleteSource.None;
            IdTxt.BackgroundImageLayout = ImageLayout.None;
            IdTxt.CharacterCasing = CharacterCasing.Normal;
            IdTxt.Depth = 0;
            IdTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IdTxt.HideSelection = true;
            IdTxt.Hint = "Id";
            IdTxt.LeadingIcon = null;
            IdTxt.Location = new Point(6, 86);
            IdTxt.MaxLength = 32767;
            IdTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IdTxt.Name = "IdTxt";
            IdTxt.PasswordChar = '\0';
            IdTxt.PrefixSuffixText = null;
            IdTxt.ReadOnly = false;
            IdTxt.RightToLeft = RightToLeft.No;
            IdTxt.SelectedText = "";
            IdTxt.SelectionLength = 0;
            IdTxt.SelectionStart = 0;
            IdTxt.ShortcutsEnabled = true;
            IdTxt.Size = new Size(66, 48);
            IdTxt.TabIndex = 2;
            IdTxt.TabStop = false;
            IdTxt.TextAlign = HorizontalAlignment.Left;
            IdTxt.TrailingIcon = null;
            IdTxt.UseSystemPasswordChar = false;
            // 
            // DepartamentoTxt
            // 
            DepartamentoTxt.AnimateReadOnly = false;
            DepartamentoTxt.AutoCompleteMode = AutoCompleteMode.None;
            DepartamentoTxt.AutoCompleteSource = AutoCompleteSource.None;
            DepartamentoTxt.BackgroundImageLayout = ImageLayout.None;
            DepartamentoTxt.CharacterCasing = CharacterCasing.Normal;
            DepartamentoTxt.Depth = 0;
            DepartamentoTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DepartamentoTxt.HideSelection = true;
            DepartamentoTxt.Hint = "Nome";
            DepartamentoTxt.LeadingIcon = null;
            DepartamentoTxt.Location = new Point(86, 86);
            DepartamentoTxt.MaxLength = 32767;
            DepartamentoTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DepartamentoTxt.Name = "DepartamentoTxt";
            DepartamentoTxt.PasswordChar = '\0';
            DepartamentoTxt.PrefixSuffixText = null;
            DepartamentoTxt.ReadOnly = false;
            DepartamentoTxt.RightToLeft = RightToLeft.No;
            DepartamentoTxt.SelectedText = "";
            DepartamentoTxt.SelectionLength = 0;
            DepartamentoTxt.SelectionStart = 0;
            DepartamentoTxt.ShortcutsEnabled = true;
            DepartamentoTxt.Size = new Size(425, 48);
            DepartamentoTxt.TabIndex = 3;
            DepartamentoTxt.TabStop = false;
            DepartamentoTxt.TextAlign = HorizontalAlignment.Left;
            DepartamentoTxt.TrailingIcon = null;
            DepartamentoTxt.UseSystemPasswordChar = false;
            // 
            // CadastroDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 403);
            Location = new Point(0, 0);
            Name = "CadastroDepartamentos";
            Text = "Cadastro de Departamentos";
            Load += CadastroDepartamentos_Load;
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdFilial;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private System.Windows.Forms.TabControl tabControlCadastro;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit DepartamentoTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit IdTxt;
    }
}