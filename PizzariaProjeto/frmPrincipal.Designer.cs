namespace PizzariaProjeto
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.ferramentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.pizzaToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources._7772_32x32;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.funcionariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.funcionariosToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources.add_male_user_32;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionários";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.pizzaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pizzaToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources.pizza_slice_32;
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.pizzaToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pedidosToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources._11496_32x32;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.relatorioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatorioToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources._4215_32x32;
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.relatorioToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1,
            this.ajudaToolStripMenuItem});
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sobreToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources.logo_pizzaria_01_x32;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.sobreToolStripMenuItem1.Image = global::PizzariaProjeto.Properties.Resources.info_32;
            this.sobreToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(121, 38);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources.help_32;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(121, 38);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources.Logout_Icon_32;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(70, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentosToolStripMenuItem
            // 
            this.ferramentosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ferramentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.ferramentosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ferramentosToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources.settings_32;
            this.ferramentosToolStripMenuItem.Name = "ferramentosToolStripMenuItem";
            this.ferramentosToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.ferramentosToolStripMenuItem.Text = "Ferramentas";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.backupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backupToolStripMenuItem.Image = global::PizzariaProjeto.Properties.Resources.download_database_32;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PizzariaProjeto.Properties.Resources.IMG_LogoPrinc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(761, 405);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}