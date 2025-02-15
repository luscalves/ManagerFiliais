namespace ManagerFiliais.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFuncionariosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFiliaisToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeDepartamentosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFuncionáriosEmPToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFuncionárioEmProjetoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(3, 747);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1481, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.Text = "Usuário: ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1481, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeUsuariosToolStripMenuItem, cadastroDeFuncionariosToolStripMenuItem, cadastroDeFiliaisToolStripMenuItem, cadastroDeDepartamentosToolStripMenuItem, cadastroDeFuncionáriosEmPToolStripMenuItem, cadastroDeFuncionárioEmProjetoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeUsuariosToolStripMenuItem
            // 
            cadastroDeUsuariosToolStripMenuItem.Name = "cadastroDeUsuariosToolStripMenuItem";
            cadastroDeUsuariosToolStripMenuItem.Size = new Size(330, 26);
            cadastroDeUsuariosToolStripMenuItem.Text = "Cadastro de Usuários";
            cadastroDeUsuariosToolStripMenuItem.Click += cadastroDeUsuariosToolStripMenuItem_Click;
            // 
            // cadastroDeFuncionariosToolStripMenuItem
            // 
            cadastroDeFuncionariosToolStripMenuItem.Name = "cadastroDeFuncionariosToolStripMenuItem";
            cadastroDeFuncionariosToolStripMenuItem.Size = new Size(330, 26);
            cadastroDeFuncionariosToolStripMenuItem.Text = "Cadastro de Funcionários";
            cadastroDeFuncionariosToolStripMenuItem.Click += cadastroDeFuncionariosToolStripMenuItem_Click;
            // 
            // cadastroDeFiliaisToolStripMenuItem
            // 
            cadastroDeFiliaisToolStripMenuItem.Name = "cadastroDeFiliaisToolStripMenuItem";
            cadastroDeFiliaisToolStripMenuItem.Size = new Size(330, 26);
            cadastroDeFiliaisToolStripMenuItem.Text = "Cadastro de Filiais";
            cadastroDeFiliaisToolStripMenuItem.Click += cadastroDeFiliaisToolStripMenuItem_Click;
            // 
            // cadastroDeDepartamentosToolStripMenuItem
            // 
            cadastroDeDepartamentosToolStripMenuItem.Name = "cadastroDeDepartamentosToolStripMenuItem";
            cadastroDeDepartamentosToolStripMenuItem.Size = new Size(330, 26);
            cadastroDeDepartamentosToolStripMenuItem.Text = "Cadastro de Departamentos";
            cadastroDeDepartamentosToolStripMenuItem.Click += cadastroDeDepartamentosToolStripMenuItem_Click;
            // 
            // cadastroDeFuncionáriosEmPToolStripMenuItem
            // 
            cadastroDeFuncionáriosEmPToolStripMenuItem.Name = "cadastroDeFuncionáriosEmPToolStripMenuItem";
            cadastroDeFuncionáriosEmPToolStripMenuItem.Size = new Size(330, 26);
            cadastroDeFuncionáriosEmPToolStripMenuItem.Text = "Cadastro de Projetos";
            cadastroDeFuncionáriosEmPToolStripMenuItem.Click += cadastroDeFuncionáriosEmPToolStripMenuItem_Click;
            // 
            // cadastroDeFuncionárioEmProjetoToolStripMenuItem
            // 
            cadastroDeFuncionárioEmProjetoToolStripMenuItem.Name = "cadastroDeFuncionárioEmProjetoToolStripMenuItem";
            cadastroDeFuncionárioEmProjetoToolStripMenuItem.Size = new Size(330, 26);
            cadastroDeFuncionárioEmProjetoToolStripMenuItem.Text = "Cadastro de Funcionário em Projeto";
            cadastroDeFuncionárioEmProjetoToolStripMenuItem.Click += cadastroDeFuncionárioEmProjetoToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1487, 776);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Gerenciador de Filiais";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFuncionariosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFiliaisToolStripMenuItem;
        private ToolStripMenuItem cadastroDeDepartamentosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFuncionáriosEmPToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFuncionárioEmProjetoToolStripMenuItem;
    }
}