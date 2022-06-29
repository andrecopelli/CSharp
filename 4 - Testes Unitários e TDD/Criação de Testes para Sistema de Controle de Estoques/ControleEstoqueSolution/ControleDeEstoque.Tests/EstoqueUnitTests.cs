using System;
using System.Collections.Generic;
using NUnit.Framework;
using ControleEstoque;

namespace ControleDeEstoque.Tests
{
    public class EstoqueUnitTests
    {
        [Test]
        public void Quando_CadastrarProdutoNoEstoque_E_ProdutoNaoExistirNoEstoque_Entao_DeveConcluirCadastro()
        {
            var novaLista = new List<Produto>();
            var novoProduto = new Produto("SSD 480 GB", "Armazenamento");
            novaLista.Add(novoProduto);
            var novoProdutoParaComparar = new Produto("Memoria RAM 16GB", "Melhora a performance do computador");
            var produtoExiste = novaLista.TrueForAll(y => y.Equals(novoProdutoParaComparar));
            Assert.IsFalse(produtoExiste);
        }

        [Test]
        public void Quando_CadastrarProdutoNoEstoque_E_ProdutoExistirNoEstoque_Entao_NaoDeveConcluirCadastro()
        {
            var novaLista = new List<Produto>();
            var novoProduto = new Produto("Memoria RAM 16GB", "Melhora a performance do computador");
            novaLista.Add(novoProduto);
            var novoEstoque = new Estoque(novaLista);
            var ex = Assert.Throws<ControleEstoque.Excecoes.ProdutoJaCadastradoException>(() => novoEstoque.CadastrarProdutoNoEstoque("Memoria RAM 16GB", "Melhora a performance do computador"));
            Assert.That(ex.Message, Is.EqualTo("Produto já existe no estoque"));
        }
        
        [Test]
        public void Quando_RegistrarAEntradaDeProdutoNoEstoque_E_ProdutoNãoExistirNoEstoque_Entao_NaoDeveConcluirAAcao()
        {
            var novaLista = new List<Produto>();
            var novoEstoque = new Estoque(novaLista);
            var ex = Assert.Throws<ControleEstoque.Excecoes.ProdutoNaoEncontradoException>(() => novoEstoque.RegistrarEntradaDeProduto(1, 20));
            Assert.That(ex.Message, Is.EqualTo("Produto não cadastrado no estoque"));
        }

        [Test]
        public void Quando_RegistrarAEntradaDe5ItensDeProdutoNoEstoque_E_ProdutoExistirNoEstoque_Entao_DeveConcluirAAcao()
        {
            var novoProduto = new Produto("Memoria RAM 16GB", "Melhora a performance do computador");
            var novaLista = new List<Produto>();
            novaLista.Add(novoProduto);
            var novoEstoque = new Estoque(novaLista);
            novoEstoque.RegistrarEntradaDeProduto(0, 20);
            novoEstoque.RegistrarEntradaDeProduto(0, 5);
            var produtoExisteNoEstoque = false;
            foreach (var item in novaLista)
            {
                if (item.Id == novoProduto.Id)
                {
                    produtoExisteNoEstoque = true;
                }
            }
            Assert.IsTrue(produtoExisteNoEstoque);
        }

        [Test]
        public void Quando_RegistrarASaidaDe5ItensDeProdutoNoEstoque_E_ProdutoNaoExistirNoEstoque_Entao_NaoDeveConcluirAAcao()
        {
            var novaLista = new List<Produto>();
            var novoEstoque = new Estoque(novaLista);
            var ex = Assert.Throws<ControleEstoque.Excecoes.ProdutoNaoEncontradoException>(() => novoEstoque.RegistrarSaidaDeProduto(1, 5));
            Assert.That(ex.Message, Is.EqualTo("Produto não cadastrado no estoque"));
        }
        
        [Test]
        public void Quando_RegistrarASaidaDe5ItensDeProdutoNoEstoque_E_ProdutoExistirNoEstoque_E_AQuantidadeForIgualOuMaiorA5_Entao_DeveConcluirAAcao()
        {
            var novoProduto = new Produto("Memoria RAM 16GB", "Melhora a performance do computador", 6);
            var novaLista = new List<Produto>();
            novaLista.Add(novoProduto);
            var novoEstoque = new Estoque(novaLista);
            novoEstoque.RegistrarSaidaDeProduto(0, 5);
            var qtdDeProdutos = novoProduto.QuantidadeEmEstoque;
            Assert.AreEqual(1, qtdDeProdutos);
        }

        [Test]
        public void Quando_VerificarSeHaItensNoEstoque_E_AQuantidadeDeItensForIgualA0_Entao_DeveInformarQueNaoHa()
        {
            var novaLista = new List<Produto>();
            var novoEstoque = new Estoque(novaLista);
            var itensNoEstoque = novaLista.Count;
            Assert.AreEqual(0, itensNoEstoque);
        }

        [Test]
        public void Quando_VerificarSeHaItensNoEstoque_E_AQuantidadeDeItensForMaiorQue0_Entao_DeveInformarQueHa()
        {
            var novoProduto = new Produto("Memoria RAM 16GB", "Melhora a performance do computador", 6);
            var novaLista = new List<Produto>();
            novaLista.Add(novoProduto);
            var novoEstoque = new Estoque(novaLista);
            var itensNoEstoque = novaLista.Count;
            Assert.AreEqual(1, itensNoEstoque);
        }
    }
}