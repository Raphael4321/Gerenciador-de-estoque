﻿namespace Gerenciador_de_estoque
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductBtn = new System.Windows.Forms.Button();
            this.btnSupplierMenu = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnMvm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductBtn
            // 
            this.ProductBtn.Location = new System.Drawing.Point(435, 12);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(136, 48);
            this.ProductBtn.TabIndex = 0;
            this.ProductBtn.Text = "Produtos";
            this.ProductBtn.UseVisualStyleBackColor = true;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // btnSupplierMenu
            // 
            this.btnSupplierMenu.Location = new System.Drawing.Point(617, 12);
            this.btnSupplierMenu.Name = "btnSupplierMenu";
            this.btnSupplierMenu.Size = new System.Drawing.Size(136, 48);
            this.btnSupplierMenu.TabIndex = 1;
            this.btnSupplierMenu.Text = "Fornecedores";
            this.btnSupplierMenu.UseVisualStyleBackColor = true;
            this.btnSupplierMenu.Click += new System.EventHandler(this.btnSupplierMenu_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(117, 36);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 39);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(98, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Movimentação de: ";
            // 
            // btnMvm
            // 
            this.btnMvm.Location = new System.Drawing.Point(308, 332);
            this.btnMvm.Name = "btnMvm";
            this.btnMvm.Size = new System.Drawing.Size(136, 48);
            this.btnMvm.TabIndex = 6;
            this.btnMvm.Text = "Nova Movimentação";
            this.btnMvm.UseVisualStyleBackColor = true;
            this.btnMvm.Click += new System.EventHandler(this.btnMvm_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMvm);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSupplierMenu);
            this.Controls.Add(this.ProductBtn);
            this.Name = "Home";
            this.Text = "Movimentações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Button btnSupplierMenu;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnMvm;
    }
}

