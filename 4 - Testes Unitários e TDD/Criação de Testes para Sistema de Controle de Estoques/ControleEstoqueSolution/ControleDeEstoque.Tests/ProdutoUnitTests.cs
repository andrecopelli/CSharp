using System;
using NUnit.Framework;
using ControleEstoque;

namespace ControleDeEstoque.Tests
{
    public class ProdutoUnitTests
    {
        [Test]
        public void Quando_Acrescentar5ItensNoProduto_E_AQuantidadeInicialDoProdutoFor20_EntaoAtualizaAQuantidadePara25()
        {
            var novoProduto = new Produto("SSD 480 GB", "Armazenamento", 20);
            var novaquantidade = novoProduto.AcrescentarQuantidade(5);
            Assert.AreEqual(25, novaquantidade);
        }

        [Test]
        public void Quando_Acrescentar0ItensNoProduto_E_AQuantidadeInicialDoProdutoFor20_EntaoNaoDeveAtualizarAQuantidade()
        {
            var novoProduto = new Produto("Memoria RAM 16GB", "Melhora a performance do computador", 20);
            var ex = Assert.Throws<ControleEstoque.Excecoes.QuantidadeMenorOuIgualAZeroException>(() => novoProduto.AcrescentarQuantidade(0));
            Assert.That(ex.Message, Is.EqualTo("Quantidade de itens deve ser maior que zero"));
        }

        [Test]
        public void Quando_Acrescentar5NegativoItensNoProduto_E_AQuantidadeInicialDoProdutoFor20_EntaoNaoDeveAtualizarAQuantidade()
        {
            var novoProduto = new Produto("Gabinete Gamer", "Não da FPS", 20);
            var ex = Assert.Throws<ControleEstoque.Excecoes.QuantidadeMenorOuIgualAZeroException>(() => novoProduto.AcrescentarQuantidade(-5));
            Assert.That(ex.Message, Is.EqualTo("Quantidade de itens deve ser maior que zero"));
        }

        [Test]
        public void Quando_Deduzir5ItensNoProduto_E_AQuantidadeInicialDoProdutoFor20_EntaoAtualizaAQuantidadePara15()
        {
            var novoProduto = new Produto("Teclado Gamer", "As teclas dão problema em dois meses", 20);
            var novaquantidade = novoProduto.DeduzirQuantidade(5);
            Assert.AreEqual(15, novaquantidade);
        }

        [Test]
        public void Quando_Deduzir0ItensNoProduto_E_AQuantidadeInicialDoProdutoFor20_EntaoNaoDeveAtualizarAQuantidade()
        {
            var novoProduto = new Produto("Mouse Gamer", "Cade o ponteiro?", 20);
            var ex = Assert.Throws<ControleEstoque.Excecoes.QuantidadeMenorOuIgualAZeroException>(() => novoProduto.DeduzirQuantidade(0));
            Assert.That(ex.Message, Is.EqualTo("Quantidade de itens deve ser maior que zero"));
        }
        
        [Test]
        public void Quando_Deduzir5NegativoItensNoProduto_E_AQuantidadeInicialDoProdutoFor20_EntaoNaoDeveAtualizarAQuantidade()
        {
            var novoProduto = new Produto("Porta Fone De Ouvidos Gamer", "Whyyyy Lord? Whyyy?", 20);
            var ex = Assert.Throws<ControleEstoque.Excecoes.QuantidadeMenorOuIgualAZeroException>(() => novoProduto.DeduzirQuantidade(-5));
            Assert.That(ex.Message, Is.EqualTo("Quantidade de itens deve ser maior que zero"));
        }

        [Test]
        public void Quando_Deduzir6ItensNoProduto_E_AQuantidadeInicialDoProdutoFor5_EntaoAtualizaAQuantidadePara0()
        {
            var novoProduto = new Produto("Drive de disquete 5 1/4 polegadas", "Só para Hipsters", 5);
            var novaquantidade = novoProduto.DeduzirQuantidade(6);
            Assert.AreEqual(0, novaquantidade);
        }
    }
}