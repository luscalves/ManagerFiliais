namespace ManagerFiliais.App.Cadastro
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
            IdFuncioanarioTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            CargoTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            IdProjetoTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            DataTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabControlCadastro.Size = new Size(450, 372);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(DataTxt);
            tabPageCadastro.Controls.Add(IdProjetoTxt);
            tabPageCadastro.Controls.Add(CargoTxt);
            tabPageCadastro.Controls.Add(IdFuncioanarioTxt);
            tabPageCadastro.Size = new Size(442, 337);
            tabPageCadastro.Controls.SetChildIndex(IdFuncioanarioTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(CargoTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(IdProjetoTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(DataTxt, 0);
            // 
            // IdFuncioanarioTxt
            // 
            IdFuncioanarioTxt.AnimateReadOnly = false;
            IdFuncioanarioTxt.AutoCompleteMode = AutoCompleteMode.None;
            IdFuncioanarioTxt.AutoCompleteSource = AutoCompleteSource.None;
            IdFuncioanarioTxt.BackgroundImageLayout = ImageLayout.None;
            IdFuncioanarioTxt.CharacterCasing = CharacterCasing.Normal;
            IdFuncioanarioTxt.Depth = 0;
            IdFuncioanarioTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IdFuncioanarioTxt.HideSelection = true;
            IdFuncioanarioTxt.Hint = "Id do Funcionario";
            IdFuncioanarioTxt.LeadingIcon = null;
            IdFuncioanarioTxt.Location = new Point(23, 32);
            IdFuncioanarioTxt.MaxLength = 32767;
            IdFuncioanarioTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IdFuncioanarioTxt.Name = "IdFuncioanarioTxt";
            IdFuncioanarioTxt.PasswordChar = '\0';
            IdFuncioanarioTxt.PrefixSuffixText = null;
            IdFuncioanarioTxt.ReadOnly = false;
            IdFuncioanarioTxt.RightToLeft = RightToLeft.No;
            IdFuncioanarioTxt.SelectedText = "";
            IdFuncioanarioTxt.SelectionLength = 0;
            IdFuncioanarioTxt.SelectionStart = 0;
            IdFuncioanarioTxt.ShortcutsEnabled = true;
            IdFuncioanarioTxt.Size = new Size(406, 48);
            IdFuncioanarioTxt.TabIndex = 2;
            IdFuncioanarioTxt.TabStop = false;
            IdFuncioanarioTxt.TextAlign = HorizontalAlignment.Left;
            IdFuncioanarioTxt.TrailingIcon = null;
            IdFuncioanarioTxt.UseSystemPasswordChar = false;
            // 
            // CargoTxt
            // 
            CargoTxt.AnimateReadOnly = false;
            CargoTxt.AutoCompleteMode = AutoCompleteMode.None;
            CargoTxt.AutoCompleteSource = AutoCompleteSource.None;
            CargoTxt.BackgroundImageLayout = ImageLayout.None;
            CargoTxt.CharacterCasing = CharacterCasing.Normal;
            CargoTxt.Depth = 0;
            CargoTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CargoTxt.HideSelection = true;
            CargoTxt.Hint = "Cargo no Projeto";
            CargoTxt.LeadingIcon = null;
            CargoTxt.Location = new Point(23, 140);
            CargoTxt.MaxLength = 32767;
            CargoTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CargoTxt.Name = "CargoTxt";
            CargoTxt.PasswordChar = '\0';
            CargoTxt.PrefixSuffixText = null;
            CargoTxt.ReadOnly = false;
            CargoTxt.RightToLeft = RightToLeft.No;
            CargoTxt.SelectedText = "";
            CargoTxt.SelectionLength = 0;
            CargoTxt.SelectionStart = 0;
            CargoTxt.ShortcutsEnabled = true;
            CargoTxt.Size = new Size(406, 48);
            CargoTxt.TabIndex = 3;
            CargoTxt.TabStop = false;
            CargoTxt.TextAlign = HorizontalAlignment.Left;
            CargoTxt.TrailingIcon = null;
            CargoTxt.UseSystemPasswordChar = false;
            // 
            // IdProjetoTxt
            // 
            IdProjetoTxt.AnimateReadOnly = false;
            IdProjetoTxt.AutoCompleteMode = AutoCompleteMode.None;
            IdProjetoTxt.AutoCompleteSource = AutoCompleteSource.None;
            IdProjetoTxt.BackgroundImageLayout = ImageLayout.None;
            IdProjetoTxt.CharacterCasing = CharacterCasing.Normal;
            IdProjetoTxt.Depth = 0;
            IdProjetoTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IdProjetoTxt.HideSelection = true;
            IdProjetoTxt.Hint = "Id do Projeto";
            IdProjetoTxt.LeadingIcon = null;
            IdProjetoTxt.Location = new Point(23, 86);
            IdProjetoTxt.MaxLength = 32767;
            IdProjetoTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IdProjetoTxt.Name = "IdProjetoTxt";
            IdProjetoTxt.PasswordChar = '\0';
            IdProjetoTxt.PrefixSuffixText = null;
            IdProjetoTxt.ReadOnly = false;
            IdProjetoTxt.RightToLeft = RightToLeft.No;
            IdProjetoTxt.SelectedText = "";
            IdProjetoTxt.SelectionLength = 0;
            IdProjetoTxt.SelectionStart = 0;
            IdProjetoTxt.ShortcutsEnabled = true;
            IdProjetoTxt.Size = new Size(406, 48);
            IdProjetoTxt.TabIndex = 4;
            IdProjetoTxt.TabStop = false;
            IdProjetoTxt.TextAlign = HorizontalAlignment.Left;
            IdProjetoTxt.TrailingIcon = null;
            IdProjetoTxt.UseSystemPasswordChar = false;
            // 
            // DataTxt
            // 
            DataTxt.AnimateReadOnly = false;
            DataTxt.AutoCompleteMode = AutoCompleteMode.None;
            DataTxt.AutoCompleteSource = AutoCompleteSource.None;
            DataTxt.BackgroundImageLayout = ImageLayout.None;
            DataTxt.CharacterCasing = CharacterCasing.Normal;
            DataTxt.Depth = 0;
            DataTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DataTxt.HideSelection = true;
            DataTxt.Hint = "Data de Inicio";
            DataTxt.LeadingIcon = null;
            DataTxt.Location = new Point(23, 194);
            DataTxt.MaxLength = 32767;
            DataTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DataTxt.Name = "DataTxt";
            DataTxt.PasswordChar = '\0';
            DataTxt.PrefixSuffixText = null;
            DataTxt.ReadOnly = false;
            DataTxt.RightToLeft = RightToLeft.No;
            DataTxt.SelectedText = "";
            DataTxt.SelectionLength = 0;
            DataTxt.SelectionStart = 0;
            DataTxt.ShortcutsEnabled = true;
            DataTxt.Size = new Size(412, 48);
            DataTxt.TabIndex = 1;
            DataTxt.TabStop = false;
            DataTxt.TextAlign = HorizontalAlignment.Left;
            DataTxt.TrailingIcon = null;
            DataTxt.UseSystemPasswordChar = false;
            // 
            // CadastroFuncionariosProjetos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 439);
            Location = new Point(0, 0);
            Name = "CadastroFuncionariosProjetos";
            Text = "CadastroFuncionariosProjetos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit IdFuncioanarioTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit IdProjetoTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit CargoTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit DataTxt;
    }
}