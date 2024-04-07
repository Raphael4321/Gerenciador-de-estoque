﻿using System;
using System.Windows.Forms;
using Gerenciador_de_estoque.src.UI;
using Gerenciador_de_estoque.UI;

namespace Gerenciador_de_estoque
{
    public partial class Home : Form
    {
        ProductMenu productMenu;
        SupplierMenu supplierMenu;
        SupplyMovementMenu supplyMovementMenu = new SupplyMovementMenu();

        public Home()
        {
            InitializeComponent();
            CreateNewProductMenu();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            ShowProductMenu();
        }

        private void ShowProductMenu()
        {
            try
            {
                Hide();
                productMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao mostrar o menu do produto: {ex.Message}");
            }
        }

        private void CreateNewProductMenu()
        {
            this.productMenu = new ProductMenu();
            productMenu.FormClosed += ProductMenu_FormClosed;
        }

        private void ProductMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            CreateNewProductMenu();
        }

        private void btnSupplierMenu_Click(object sender, EventArgs e)
        {
            CreateNewSupplierMenu(false);
            ShowSupplierMenu();
        }


        private void ShowSupplierMenu()
        {
            try
            {
                Hide();
                supplierMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao mostrar o menu do fornecedor: {ex.Message}");
            }
        }

        private void CreateNewSupplierMenu(bool isSelecting)
        {
            this.supplierMenu = new SupplierMenu(isSelecting);
            supplierMenu.FormClosed += SupplierMenu_FormClosed;
        }

        private void SupplierMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            CreateNewSupplierMenu(false);
        }

        private void ShowSupplyMovementMenu()
        {
            try
            {
                Hide();
                supplyMovementMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao mostrar o menu de movimentação de suprimentos: {ex.Message}");
            }
        }

        private void CreateNewSupplyMovementMenu()
        {
            this.supplyMovementMenu = new SupplyMovementMenu();
            supplyMovementMenu.FormClosed += SupplyMovementMenu_FormClosed;
        }

        private void SupplyMovementMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            CreateNewSupplyMovementMenu();
        }

        private void btnMvm_Click(object sender, EventArgs e)
        {
            ShowSupplyMovementMenu();
        }
    }
}
