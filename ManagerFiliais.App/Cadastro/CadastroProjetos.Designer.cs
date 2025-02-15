namespace ManagerFiliais.App.Cadastro
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
            IdTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            DataInicioTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            DataFimTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEdit5 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabControlCadastro.Size = new Size(463, 317);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialTextBoxEdit5);
            tabPageCadastro.Controls.Add(DataFimTxt);
            tabPageCadastro.Controls.Add(DataInicioTxt);
            tabPageCadastro.Controls.Add(IdTxt);
            tabPageCadastro.Size = new Size(455, 282);
            tabPageCadastro.Controls.SetChildIndex(IdTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(DataInicioTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(DataFimTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(materialTextBoxEdit5, 0);
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
            IdTxt.Location = new Point(25, 30);
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
            IdTxt.Size = new Size(61, 48);
            IdTxt.TabIndex = 2;
            IdTxt.TabStop = false;
            IdTxt.TextAlign = HorizontalAlignment.Left;
            IdTxt.TrailingIcon = null;
            IdTxt.UseSystemPasswordChar = false;
            // 
            // DataInicioTxt
            // 
            DataInicioTxt.AnimateReadOnly = false;
            DataInicioTxt.AutoCompleteMode = AutoCompleteMode.None;
            DataInicioTxt.AutoCompleteSource = AutoCompleteSource.None;
            DataInicioTxt.BackgroundImageLayout = ImageLayout.None;
            DataInicioTxt.CharacterCasing = CharacterCasing.Normal;
            DataInicioTxt.Depth = 0;
            DataInicioTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DataInicioTxt.HideSelection = true;
            DataInicioTxt.Hint = "Data de Inicio";
            DataInicioTxt.LeadingIcon = null;
            DataInicioTxt.Location = new Point(25, 84);
            DataInicioTxt.MaxLength = 32767;
            DataInicioTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DataInicioTxt.Name = "DataInicioTxt";
            DataInicioTxt.PasswordChar = '\0';
            DataInicioTxt.PrefixSuffixText = null;
            DataInicioTxt.ReadOnly = false;
            DataInicioTxt.RightToLeft = RightToLeft.No;
            DataInicioTxt.SelectedText = "";
            DataInicioTxt.SelectionLength = 0;
            DataInicioTxt.SelectionStart = 0;
            DataInicioTxt.ShortcutsEnabled = true;
            DataInicioTxt.Size = new Size(423, 48);
            DataInicioTxt.TabIndex = 3;
            DataInicioTxt.TabStop = false;
            DataInicioTxt.TextAlign = HorizontalAlignment.Left;
            DataInicioTxt.TrailingIcon = null;
            DataInicioTxt.UseSystemPasswordChar = false;
            // 
            // DataFimTxt
            // 
            DataFimTxt.AnimateReadOnly = false;
            DataFimTxt.AutoCompleteMode = AutoCompleteMode.None;
            DataFimTxt.AutoCompleteSource = AutoCompleteSource.None;
            DataFimTxt.BackgroundImageLayout = ImageLayout.None;
            DataFimTxt.CharacterCasing = CharacterCasing.Normal;
            DataFimTxt.Depth = 0;
            DataFimTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DataFimTxt.HideSelection = true;
            DataFimTxt.Hint = "Data do Fim";
            DataFimTxt.LeadingIcon = null;
            DataFimTxt.Location = new Point(25, 138);
            DataFimTxt.MaxLength = 32767;
            DataFimTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DataFimTxt.Name = "DataFimTxt";
            DataFimTxt.PasswordChar = '\0';
            DataFimTxt.PrefixSuffixText = null;
            DataFimTxt.ReadOnly = false;
            DataFimTxt.RightToLeft = RightToLeft.No;
            DataFimTxt.SelectedText = "";
            DataFimTxt.SelectionLength = 0;
            DataFimTxt.SelectionStart = 0;
            DataFimTxt.ShortcutsEnabled = true;
            DataFimTxt.Size = new Size(423, 48);
            DataFimTxt.TabIndex = 4;
            DataFimTxt.TabStop = false;
            DataFimTxt.TextAlign = HorizontalAlignment.Left;
            DataFimTxt.TrailingIcon = null;
            DataFimTxt.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit5
            // 
            materialTextBoxEdit5.AnimateReadOnly = false;
            materialTextBoxEdit5.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit5.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit5.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit5.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit5.Depth = 0;
            materialTextBoxEdit5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit5.HideSelection = true;
            materialTextBoxEdit5.Hint = "Nome do Projeto";
            materialTextBoxEdit5.LeadingIcon = null;
            materialTextBoxEdit5.Location = new Point(92, 30);
            materialTextBoxEdit5.MaxLength = 32767;
            materialTextBoxEdit5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit5.Name = "materialTextBoxEdit5";
            materialTextBoxEdit5.PasswordChar = '\0';
            materialTextBoxEdit5.PrefixSuffixText = null;
            materialTextBoxEdit5.ReadOnly = false;
            materialTextBoxEdit5.RightToLeft = RightToLeft.No;
            materialTextBoxEdit5.SelectedText = "";
            materialTextBoxEdit5.SelectionLength = 0;
            materialTextBoxEdit5.SelectionStart = 0;
            materialTextBoxEdit5.ShortcutsEnabled = true;
            materialTextBoxEdit5.Size = new Size(356, 48);
            materialTextBoxEdit5.TabIndex = 5;
            materialTextBoxEdit5.TabStop = false;
            materialTextBoxEdit5.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit5.TrailingIcon = null;
            materialTextBoxEdit5.UseSystemPasswordChar = false;
            // 
            // CadastroProjetos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 384);
            Location = new Point(0, 0);
            Name = "CadastroProjetos";
            Text = "Cadastro de Projetos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit DataFimTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit DataInicioTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit IdTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit5;
    }
}