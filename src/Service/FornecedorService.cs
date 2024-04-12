﻿using System.Collections.Generic;
using Gerenciador_de_estoque.src.Models;
using Gerenciador_de_estoque.src.Repositories;

namespace Gerenciador_de_estoque.src.Services
{
    public class FornecedorService
    {
        readonly FornecedorRepository fornecedorRepository = new FornecedorRepository();

        public List<Supplier> GatherFornecedores(string nome)
        {
            return fornecedorRepository.GatherFornecedores(nome);
        }

        public Supplier GetOneFornecedor(int id)
        {
            return fornecedorRepository.GetOneFornecedor(id);
        }

        public void AddFornecedor(Supplier fornecedor)
        {
            fornecedorRepository.AddFornecedor(fornecedor);
        }

        public void UpdateFornecedor(Supplier fornecedor)
        {
            fornecedorRepository.UpdateFornecedor(fornecedor);
        }

        public void DeleteFornecedor(int id)
        {
            fornecedorRepository.DeleteFornecedor(id);
        }
    }
}
