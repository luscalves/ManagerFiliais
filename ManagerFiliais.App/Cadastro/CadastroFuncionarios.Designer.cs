namespace ManagerFiliais.App.Cadastro
{
    partial class CadastroFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionarios));
            IdTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            NomeTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            CargoTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabControlCadastro.Size = new Size(533, 284);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(CargoTxt);
            tabPageCadastro.Controls.Add(NomeTxt);
            tabPageCadastro.Controls.Add(IdTxt);
            tabPageCadastro.Size = new Size(525, 249);
            tabPageCadastro.Controls.SetChildIndex(IdTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(NomeTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(CargoTxt, 0);
            // 
            // IdTxt
            // 
            IdTxt.AnimateReadOnly = false;
            IdTxt.AutoCompleteMode = AutoCompleteMode.None;
            IdTxt.AutoCompleteSource = AutoCompleteSource.None;
            IdTxt.BackgroundImageLayout = ImageLayout.None;
            IdTxt.CharacterCasing = CharacterCasing.Normal;
            IdTxt.Depth = 0;
            IdTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IdTxt.HideSelection = true;
            IdTxt.Hint = "Id";
            IdTxt.LeadingIcon = null;
            IdTxt.Location = new Point(6, 44);
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
            IdTxt.Size = new Size(77, 48);
            IdTxt.TabIndex = 2;
            IdTxt.TabStop = false;
            IdTxt.TextAlign = HorizontalAlignment.Left;
            IdTxt.TrailingIcon = null;
            IdTxt.UseSystemPasswordChar = false;
            // 
            // NomeTxt
            // 
            NomeTxt.AnimateReadOnly = false;
            NomeTxt.AutoCompleteMode = AutoCompleteMode.None;
            NomeTxt.AutoCompleteSource = AutoCompleteSource.None;
            NomeTxt.BackgroundImageLayout = ImageLayout.None;
            NomeTxt.CharacterCasing = CharacterCasing.Normal;
            NomeTxt.Depth = 0;
            NomeTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NomeTxt.HideSelection = true;
            NomeTxt.Hint = "Nome";
            NomeTxt.LeadingIcon = null;
            NomeTxt.Location = new Point(89, 44);
            NomeTxt.MaxLength = 32767;
            NomeTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NomeTxt.Name = "NomeTxt";
            NomeTxt.PasswordChar = '\0';
            NomeTxt.PrefixSuffixText = null;
            NomeTxt.ReadOnly = false;
            NomeTxt.RightToLeft = RightToLeft.No;
            NomeTxt.SelectedText = "";
            NomeTxt.SelectionLength = 0;
            NomeTxt.SelectionStart = 0;
            NomeTxt.ShortcutsEnabled = true;
            NomeTxt.Size = new Size(400, 48);
            NomeTxt.TabIndex = 3;
            NomeTxt.TabStop = false;
            NomeTxt.TextAlign = HorizontalAlignment.Left;
            NomeTxt.TrailingIcon = null;
            NomeTxt.UseSystemPasswordChar = false;
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
            CargoTxt.Hint = "Cargo";
            CargoTxt.LeadingIcon = null;
            CargoTxt.Location = new Point(6, 111);
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
            CargoTxt.Size = new Size(483, 48);
            CargoTxt.TabIndex = 4;
            CargoTxt.TabStop = false;
            CargoTxt.TextAlign = HorizontalAlignment.Left;
            CargoTxt.TrailingIcon = null;
            CargoTxt.UseSystemPasswordChar = false;
            // 
            // CadastroFuncionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 351);
            Location = new Point(0, 0);
            Name = "CadastroFuncionarios";
            Text = "Cadastro de Funcionarios";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit CargoTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit NomeTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit IdTxt;
    }
}