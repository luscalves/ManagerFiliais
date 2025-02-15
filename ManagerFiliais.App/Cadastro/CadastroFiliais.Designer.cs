namespace ManagerFiliais.App.Cadastros
{
    partial class CadastroFiliais
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TabControl tabControlCadastro;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TabPage tabPageConsulta;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFiliais));
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtTelefone = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblEndereco = new Label();
            lblTelefone = new Label();
            tabPageConsulta = new TabPage();
            btnDeletar = new Button();
            dataGridViewConsulta = new DataGridView();
            btnSalvar = new Button();
            IdTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            FilliaisTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            EndercoTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TelefoneTxt = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.Images.SetKeyName(0, "form.png");
            imageList.Images.SetKeyName(1, "search.png");
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(TelefoneTxt);
            tabPageCadastro.Controls.Add(EndercoTxt);
            tabPageCadastro.Controls.Add(FilliaisTxt);
            tabPageCadastro.Controls.Add(IdTxt);
            tabPageCadastro.Controls.SetChildIndex(IdTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(FilliaisTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(EndercoTxt, 0);
            tabPageCadastro.Controls.SetChildIndex(TelefoneTxt, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(100, 100);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(200, 27);
            txtEndereco.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(100, 140);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 27);
            txtTelefone.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 13);
            lblId.TabIndex = 4;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(35, 13);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(20, 100);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(53, 13);
            lblEndereco.TabIndex = 6;
            lblEndereco.Text = "Endereço";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(20, 140);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(49, 13);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnDeletar);
            tabPageConsulta.Location = new Point(4, 22);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(352, 214);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Controls.SetChildIndex(btnDeletar, 0);
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(0, 0);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 6;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new Point(6, 6);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.RowHeadersWidth = 51;
            dataGridViewConsulta.Size = new Size(340, 150);
            dataGridViewConsulta.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(0, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
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
            IdTxt.Location = new Point(16, 65);
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
            IdTxt.Size = new Size(89, 48);
            IdTxt.TabIndex = 2;
            IdTxt.TabStop = false;
            IdTxt.TextAlign = HorizontalAlignment.Left;
            IdTxt.TrailingIcon = null;
            IdTxt.UseSystemPasswordChar = false;
            // 
            // FilliaisTxt
            // 
            FilliaisTxt.AnimateReadOnly = false;
            FilliaisTxt.AutoCompleteMode = AutoCompleteMode.None;
            FilliaisTxt.AutoCompleteSource = AutoCompleteSource.None;
            FilliaisTxt.BackgroundImageLayout = ImageLayout.None;
            FilliaisTxt.CharacterCasing = CharacterCasing.Normal;
            FilliaisTxt.Depth = 0;
            FilliaisTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            FilliaisTxt.HideSelection = true;
            FilliaisTxt.Hint = "Nome";
            FilliaisTxt.LeadingIcon = null;
            FilliaisTxt.Location = new Point(111, 65);
            FilliaisTxt.MaxLength = 32767;
            FilliaisTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            FilliaisTxt.Name = "FilliaisTxt";
            FilliaisTxt.PasswordChar = '\0';
            FilliaisTxt.PrefixSuffixText = null;
            FilliaisTxt.ReadOnly = false;
            FilliaisTxt.RightToLeft = RightToLeft.No;
            FilliaisTxt.SelectedText = "";
            FilliaisTxt.SelectionLength = 0;
            FilliaisTxt.SelectionStart = 0;
            FilliaisTxt.ShortcutsEnabled = true;
            FilliaisTxt.Size = new Size(667, 48);
            FilliaisTxt.TabIndex = 3;
            FilliaisTxt.TabStop = false;
            FilliaisTxt.TextAlign = HorizontalAlignment.Left;
            FilliaisTxt.TrailingIcon = null;
            FilliaisTxt.UseSystemPasswordChar = false;
            // 
            // EndercoTxt
            // 
            EndercoTxt.AnimateReadOnly = false;
            EndercoTxt.AutoCompleteMode = AutoCompleteMode.None;
            EndercoTxt.AutoCompleteSource = AutoCompleteSource.None;
            EndercoTxt.BackgroundImageLayout = ImageLayout.None;
            EndercoTxt.CharacterCasing = CharacterCasing.Normal;
            EndercoTxt.Depth = 0;
            EndercoTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EndercoTxt.HideSelection = true;
            EndercoTxt.Hint = "Endereço";
            EndercoTxt.LeadingIcon = null;
            EndercoTxt.Location = new Point(16, 137);
            EndercoTxt.MaxLength = 32767;
            EndercoTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            EndercoTxt.Name = "EndercoTxt";
            EndercoTxt.PasswordChar = '\0';
            EndercoTxt.PrefixSuffixText = null;
            EndercoTxt.ReadOnly = false;
            EndercoTxt.RightToLeft = RightToLeft.No;
            EndercoTxt.SelectedText = "";
            EndercoTxt.SelectionLength = 0;
            EndercoTxt.SelectionStart = 0;
            EndercoTxt.ShortcutsEnabled = true;
            EndercoTxt.Size = new Size(762, 48);
            EndercoTxt.TabIndex = 4;
            EndercoTxt.TabStop = false;
            EndercoTxt.TextAlign = HorizontalAlignment.Left;
            EndercoTxt.TrailingIcon = null;
            EndercoTxt.UseSystemPasswordChar = false;
            // 
            // TelefoneTxt
            // 
            TelefoneTxt.AnimateReadOnly = false;
            TelefoneTxt.AutoCompleteMode = AutoCompleteMode.None;
            TelefoneTxt.AutoCompleteSource = AutoCompleteSource.None;
            TelefoneTxt.BackgroundImageLayout = ImageLayout.None;
            TelefoneTxt.CharacterCasing = CharacterCasing.Normal;
            TelefoneTxt.Depth = 0;
            TelefoneTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TelefoneTxt.HideSelection = true;
            TelefoneTxt.Hint = "Telefone";
            TelefoneTxt.LeadingIcon = null;
            TelefoneTxt.Location = new Point(16, 191);
            TelefoneTxt.MaxLength = 32767;
            TelefoneTxt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TelefoneTxt.Name = "TelefoneTxt";
            TelefoneTxt.PasswordChar = '\0';
            TelefoneTxt.PrefixSuffixText = null;
            TelefoneTxt.ReadOnly = false;
            TelefoneTxt.RightToLeft = RightToLeft.No;
            TelefoneTxt.SelectedText = "";
            TelefoneTxt.SelectionLength = 0;
            TelefoneTxt.SelectionStart = 0;
            TelefoneTxt.ShortcutsEnabled = true;
            TelefoneTxt.Size = new Size(492, 48);
            TelefoneTxt.TabIndex = 5;
            TelefoneTxt.TabStop = false;
            TelefoneTxt.TextAlign = HorizontalAlignment.Left;
            TelefoneTxt.TrailingIcon = null;
            TelefoneTxt.UseSystemPasswordChar = false;
            // 
            // CadastroFiliais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            ClientSize = new Size(806, 444);
            Location = new Point(0, 0);
            Name = "CadastroFiliais";
            Text = "Cadastro de Filiais";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private ReaLTaiizor.Controls.MaterialTextBoxEdit TelefoneTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit EndercoTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit FilliaisTxt;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit IdTxt;
    }
}