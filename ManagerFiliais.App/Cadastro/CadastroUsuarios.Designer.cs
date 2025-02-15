namespace ManagerFiliais.App.Cadastro
{
    partial class CadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuarios));
            NomeTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            EmailTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SenhaTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            IdTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabControlCadastro.Size = new Size(651, 327);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(IdTxt);
            tabPageCadastro.Controls.Add(SenhaTxt);
            tabPageCadastro.Controls.Add(EmailTxt);
            tabPageCadastro.Controls.Add(NomeTxt);
            tabPageCadastro.Size = new Size(643, 292);
            tabPageCadastro.Controls.SetChildIndex(NomeTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(EmailTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(SenhaTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(IdTxt, 0);
            // 
            // NomeTxt
            // 
            NomeTxt.AnimateReadOnly = false;
            NomeTxt.AutoCompleteMode = AutoCompleteMode.None;
            NomeTxt.AutoCompleteSource = AutoCompleteSource.None;
            NomeTxt.BackgroundImageLayout = ImageLayout.None;
            NomeTxt.CharacterCasing = CharacterCasing.Normal;
            NomeTxt.Depth = 0;
            NomeTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NomeTxt.HideSelection = true;
            NomeTxt.Hint = "Nome";
            NomeTxt.LeadingIcon = null;
            NomeTxt.Location = new Point(130, 19);
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
            NomeTxt.Size = new Size(501, 48);
            NomeTxt.TabIndex = 2;
            NomeTxt.TabStop = false;
            NomeTxt.TextAlign = HorizontalAlignment.Left;
            NomeTxt.TrailingIcon = null;
            NomeTxt.UseSystemPasswordChar = false;
            // 
            // EmailTxt
            // 
            EmailTxt.AnimateReadOnly = false;
            EmailTxt.AutoCompleteMode = AutoCompleteMode.None;
            EmailTxt.AutoCompleteSource = AutoCompleteSource.None;
            EmailTxt.BackgroundImageLayout = ImageLayout.None;
            EmailTxt.CharacterCasing = CharacterCasing.Normal;
            EmailTxt.Depth = 0;
            EmailTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EmailTxt.HideSelection = true;
            EmailTxt.Hint = "Email";
            EmailTxt.LeadingIcon = null;
            EmailTxt.Location = new Point(3, 73);
            EmailTxt.MaxLength = 32767;
            EmailTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PasswordChar = '\0';
            EmailTxt.PrefixSuffixText = null;
            EmailTxt.ReadOnly = false;
            EmailTxt.RightToLeft = RightToLeft.No;
            EmailTxt.SelectedText = "";
            EmailTxt.SelectionLength = 0;
            EmailTxt.SelectionStart = 0;
            EmailTxt.ShortcutsEnabled = true;
            EmailTxt.Size = new Size(628, 48);
            EmailTxt.TabIndex = 3;
            EmailTxt.TabStop = false;
            EmailTxt.TextAlign = HorizontalAlignment.Left;
            EmailTxt.TrailingIcon = null;
            EmailTxt.UseSystemPasswordChar = false;
            // 
            // SenhaTxt
            // 
            SenhaTxt.AnimateReadOnly = false;
            SenhaTxt.AutoCompleteMode = AutoCompleteMode.None;
            SenhaTxt.AutoCompleteSource = AutoCompleteSource.None;
            SenhaTxt.BackgroundImageLayout = ImageLayout.None;
            SenhaTxt.CharacterCasing = CharacterCasing.Normal;
            SenhaTxt.Depth = 0;
            SenhaTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SenhaTxt.HideSelection = true;
            SenhaTxt.Hint = "Senha";
            SenhaTxt.LeadingIcon = null;
            SenhaTxt.Location = new Point(0, 127);
            SenhaTxt.MaxLength = 32767;
            SenhaTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            SenhaTxt.Name = "SenhaTxt";
            SenhaTxt.PasswordChar = '●';
            SenhaTxt.PrefixSuffixText = null;
            SenhaTxt.ReadOnly = false;
            SenhaTxt.RightToLeft = RightToLeft.No;
            SenhaTxt.SelectedText = "";
            SenhaTxt.SelectionLength = 0;
            SenhaTxt.SelectionStart = 0;
            SenhaTxt.ShortcutsEnabled = true;
            SenhaTxt.Size = new Size(631, 48);
            SenhaTxt.TabIndex = 4;
            SenhaTxt.TabStop = false;
            SenhaTxt.TextAlign = HorizontalAlignment.Left;
            SenhaTxt.TrailingIcon = null;
            SenhaTxt.UseSystemPasswordChar = true;
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
            IdTxt.Location = new Point(6, 19);
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
            IdTxt.Size = new Size(113, 48);
            IdTxt.TabIndex = 5;
            IdTxt.TabStop = false;
            IdTxt.TextAlign = HorizontalAlignment.Left;
            IdTxt.TrailingIcon = null;
            IdTxt.UseSystemPasswordChar = false;
            // 
            // CadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 394);
            Location = new Point(0, 0);
            Name = "CadastroUsuarios";
            Text = "CadastroUsuarios";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit SenhaTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit EmailTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit NomeTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit IdTxt;
    }
}