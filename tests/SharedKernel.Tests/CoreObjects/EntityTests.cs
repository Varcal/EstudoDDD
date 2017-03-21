using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedKernel.Tests.CoreObjects.Classes;

namespace SharedKernel.Tests.CoreObjects
{
    [TestClass]
    public class EntityTests
    {
        [TestMethod]
        [TestCategory("Entity - Core")]
        public void Deve_ser_igual()
        {
            var entidade1 = new Entidade(1, "Criado");
            var entidade2 = new Entidade(1, "Alterado");

            Assert.AreEqual(entidade1, entidade2);
            Assert.IsTrue(entidade1 == entidade2);
            Assert.IsTrue(entidade1.Equals(entidade2));
        }

        [TestMethod]
        [TestCategory("Entity - Core")]
        public void Deve_ter_hascode_igual()
        {
            var entidade1 = new Entidade(1, "Criado");
            var entidade2 = new Entidade(1, "Alterado");

            Assert.AreEqual(entidade1.GetHashCode(), entidade2.GetHashCode());
            Assert.IsTrue(entidade1.GetHashCode() == entidade2.GetHashCode());
            Assert.IsTrue(entidade1.GetHashCode().Equals(entidade2.GetHashCode()));
        }

        [TestMethod]
        [TestCategory("Entity - Core")]
        public void Deve_ser_diferente()
        {
            var entidade1 = new Entidade(1, "Criado");
            var entidade2 = new Entidade(2, "Criado");

            Assert.AreNotEqual(entidade1, entidade2);
            Assert.IsTrue(entidade1 != entidade2);
            Assert.IsTrue(!entidade1.Equals(entidade2));
        }

        [TestMethod]
        [TestCategory("Entity - Core")]
        public void Deve_ter_hascode_diferente()
        {
            var entidade1 = new Entidade(1, "Criado");
            var entidade2 = new Entidade(2, "Alterado");

            Assert.AreNotEqual(entidade1.GetHashCode(), entidade2.GetHashCode());
            Assert.IsTrue(entidade1.GetHashCode() != entidade2.GetHashCode());
            Assert.IsTrue(!entidade1.GetHashCode().Equals(entidade2.GetHashCode()));
        }

        [TestMethod]
        [TestCategory("Entity - Core")]
        public void Deve_tornar_entidade_ativa()
        {
            var entidade = new Entidade(1, "teste");
            entidade.Ativar();

            Assert.IsTrue(entidade.Ativo);
        }

        [TestMethod]
        [TestCategory("Entity - Core")]
        public void Deve_tornar_entidade_inativa()
        {
            var entidade = new Entidade(1, "teste");
            entidade.Ativar();

            Assert.IsTrue(entidade.Ativo);
        }

        [TestMethod]
        [TestCategory("Entity - Core")]
        public void Deve_ter_data_valida()
        {
            var entidade = new Entidade(1, "Teste");

            Assert.IsTrue(entidade.DataCadastro > DateTime.MinValue);
        }
    }
}
