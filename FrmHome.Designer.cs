namespace PDV
{
    partial class frmTelaHome
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
            this.components = new System.ComponentModel.Container();
            this.MenuHome = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNovoP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLancar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovEntradas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelEntradas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelMov = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuHome
            // 
            this.MenuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.MenuCadastro, this.MenuRelProduto, this.MenuMovimentacoes, this.relatóriosToolStripMenuItem, this.sairToolStripMenuItem });
            this.MenuHome.Location = new System.Drawing.Point(0, 0);
            this.MenuHome.Name = "MenuHome";
            this.MenuHome.Size = new System.Drawing.Size(1403, 24);
            this.MenuHome.TabIndex = 0;
            this.MenuHome.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.MenuFuncionarios, this.MenuClientes, this.MenuUsuarios, this.MenuCargos, this.MenuFornecedor });
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(152, 22);
            this.MenuFuncionarios.Text = "Funcionários";
            // 
            // MenuClientes
            // 
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(152, 22);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(152, 22);
            this.MenuUsuarios.Text = "Usuários";
            // 
            // MenuRelProduto
            // 
            this.MenuRelProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.MenuNovoP, this.MenuEstoque });
            this.MenuRelProduto.Name = "MenuRelProduto";
            this.MenuRelProduto.Size = new System.Drawing.Size(67, 20);
            this.MenuRelProduto.Text = "Produtos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.MenuRelP, this.MenuVendas, this.MenuRelMov, this.MenuRelEntradas, this.MenuRelDespesas });
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.MenuFluxo, this.MenuLancar, this.MenuMovEntradas, this.MenuDespesas });
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(104, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDV.Properties.Resources.grandePato;
            this.pictureBox1.Location = new System.Drawing.Point(32, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PDV.Properties.Resources.iconeInfo;
            this.pictureBox2.Location = new System.Drawing.Point(554, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PDV.Properties.Resources.iconeCaixa;
            this.pictureBox3.Location = new System.Drawing.Point(554, 282);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(231, 221);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PDV.Properties.Resources.iconeCarrinho;
            this.pictureBox4.Location = new System.Drawing.Point(803, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(231, 221);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PDV.Properties.Resources.iconeCode;
            this.pictureBox5.Location = new System.Drawing.Point(803, 51);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(231, 221);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(152, 22);
            this.MenuCargos.Text = "Cargos";
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(152, 22);
            this.MenuFornecedor.Text = "Fornecedor";
            // 
            // MenuNovoP
            // 
            this.MenuNovoP.Name = "MenuNovoP";
            this.MenuNovoP.Size = new System.Drawing.Size(152, 22);
            this.MenuNovoP.Text = "Novo Produto";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(152, 22);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuFluxo
            // 
            this.MenuFluxo.Name = "MenuFluxo";
            this.MenuFluxo.Size = new System.Drawing.Size(163, 22);
            this.MenuFluxo.Text = "Fluxo Caixa";
            // 
            // MenuLancar
            // 
            this.MenuLancar.Name = "MenuLancar";
            this.MenuLancar.Size = new System.Drawing.Size(163, 22);
            this.MenuLancar.Text = "Lançar Venda";
            // 
            // MenuMovEntradas
            // 
            this.MenuMovEntradas.Name = "MenuMovEntradas";
            this.MenuMovEntradas.Size = new System.Drawing.Size(163, 22);
            this.MenuMovEntradas.Text = "Entradas / Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelP
            // 
            this.MenuRelP.Name = "MenuRelP";
            this.MenuRelP.Size = new System.Drawing.Size(163, 22);
            this.MenuRelP.Text = "Produtos";
            // 
            // MenuVendas
            // 
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(163, 22);
            this.MenuVendas.Text = "Vendas";
            // 
            // MenuRelEntradas
            // 
            this.MenuRelEntradas.Name = "MenuRelEntradas";
            this.MenuRelEntradas.Size = new System.Drawing.Size(163, 22);
            this.MenuRelEntradas.Text = "Entradas / Saídas";
            // 
            // MenuRelDespesas
            // 
            this.MenuRelDespesas.Name = "MenuRelDespesas";
            this.MenuRelDespesas.Size = new System.Drawing.Size(163, 22);
            this.MenuRelDespesas.Text = "Despesas";
            // 
            // MenuRelMov
            // 
            this.MenuRelMov.Name = "MenuRelMov";
            this.MenuRelMov.Size = new System.Drawing.Size(163, 22);
            this.MenuRelMov.Text = "Movimentos";
            // 
            // frmTelaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1403, 790);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuHome);
            this.MainMenuStrip = this.MenuHome;
            this.Name = "frmTelaHome";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuHome.ResumeLayout(false);
            this.MenuHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuRelProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuNovoP;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxo;
        private System.Windows.Forms.ToolStripMenuItem MenuLancar;
        private System.Windows.Forms.ToolStripMenuItem MenuMovEntradas;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelEntradas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelMov;

        private System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox pictureBox2;

        #endregion

        private System.Windows.Forms.MenuStrip MenuHome;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuRelP;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

