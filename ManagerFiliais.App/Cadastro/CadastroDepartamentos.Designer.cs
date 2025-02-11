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
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtIdFilial = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tabControlCadastro = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.btnSave = new ReaLTaiizor.Controls.MaterialButton();
            this.btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            this.tabControlCadastro.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCadastro
            // 
            this.tabControlCadastro.Controls.Add(this.tabPageCadastro);
            this.tabControlCadastro.Location = new System.Drawing.Point(12, 12);
            this.tabControlCadastro.Name = "tabControlCadastro";
            this.tabControlCadastro.SelectedIndex = 0;
            this.tabControlCadastro.Size = new System.Drawing.Size(627, 326);
            this.tabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtIdFilial);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Controls.Add(this.btnSave);
            this.tabPageCadastro.Controls.Add(this.btnDelete);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 24);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(619, 298);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(104, 23);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(326, 48);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtIdFilial
            // 
            this.txtIdFilial.AnimateReadOnly = false;
            this.txtIdFilial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdFilial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdFilial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdFilial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdFilial.Depth = 0;
            this.txtIdFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdFilial.HideSelection = true;
            this.txtIdFilial.Hint = "ID Filial";
            this.txtIdFilial.LeadingIcon = null;
            this.txtIdFilial.Location = new System.Drawing.Point(455, 22);
            this.txtIdFilial.MaxLength = 32767;
            this.txtIdFilial.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtIdFilial.Name = "txtIdFilial";
            this.txtIdFilial.PasswordChar = '\0';
            this.txtIdFilial.PrefixSuffixText = null;
            this.txtIdFilial.ReadOnly = false;
            this.txtIdFilial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdFilial.SelectedText = "";
            this.txtIdFilial.SelectionLength = 0;
            this.txtIdFilial.SelectionStart = 0;
            this.txtIdFilial.ShortcutsEnabled = true;
            this.txtIdFilial.Size = new System.Drawing.Size(151, 48);
            this.txtIdFilial.TabIndex = 2;
            this.txtIdFilial.TabStop = false;
            this.txtIdFilial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdFilial.TrailingIcon = null;
            this.txtIdFilial.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "Id";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(6, 23);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = false;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(92, 48);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(12, 350);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.RowTemplate.Height = 25;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(629, 150);
            this.dataGridViewConsulta.TabIndex = 1;
            this.dataGridViewConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsulta_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.DrawShadows = true;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(104, 77);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.DrawShadows = true;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(230, 77);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CadastroDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 512);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Controls.Add(this.tabControlCadastro);
            this.Name = "CadastroDepartamentos";
            this.Text = "Cadastro de Departamentos";
            this.Load += new System.EventHandler(this.CadastroDepartamentos_Load);
            this.tabControlCadastro.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdFilial;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private System.Windows.Forms.TabControl tabControlCadastro;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
    }
}