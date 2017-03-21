
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedKernel.Tests.CoreObjects.Classes;

namespace SharedKernel.Tests.CoreObjects
{
    [TestClass]
    public class ValueObjectTests
    {
        [TestMethod]
        [TestCategory("ValueObject - Core")]
        public void Deve_ser_igual()
        {
            var vo1 = new ObjetoValor("Name", 10);
            var vo2 = new ObjetoValor("Name", 10);

            Assert.AreEqual(vo1, vo2);
            Assert.IsTrue(vo1 == vo2);
            Assert.IsTrue(vo1.Equals(vo2));
        }

        [TestMethod]
        [TestCategory("ValueObject - Core")]
        public void Deve_ter_hashcode_igual()
        {
            var vo1 = new ObjetoValor("Name", 10);
            var vo2 = new ObjetoValor("Name", 10);

            Assert.AreEqual(vo1.GetHashCode(), vo2.GetHashCode());
            Assert.IsTrue(vo1.GetHashCode() == vo2.GetHashCode());
            Assert.IsTrue(vo1.GetHashCode().Equals(vo2.GetHashCode()));
        }

        [TestMethod]
        [TestCategory("ValueObject - Core")]
        public void Deve_ter_hashcode_diferente_se_nome_diferente()
        {
            var vo1 = new ObjetoValor("Nam", 10);
            var vo2 = new ObjetoValor("Name", 10);

            Assert.AreNotEqual(vo1.GetHashCode(), vo2.GetHashCode());
            Assert.IsTrue(vo1.GetHashCode() != vo2.GetHashCode());
        }

        [TestMethod]
        [TestCategory("ValueObject - Core")]
        public void Deve_ter_hashcode_diferente_se_valor_diferente()
        {
            var vo1 = new ObjetoValor("Nam", 11);
            var vo2 = new ObjetoValor("Name", 10);

            Assert.AreNotEqual(vo1.GetHashCode(), vo2.GetHashCode());
            Assert.IsTrue(vo1.GetHashCode() != vo2.GetHashCode());
        }

        [TestMethod]
        [TestCategory("ValueObject - Core")]
        public void Deve_ser_diferente_se_nome_diferente()
        {
            var vo1 = new ObjetoValor("Nam", 10);
            var vo2 = new ObjetoValor("Name", 10);

            Assert.AreNotEqual(vo1, vo2);
            Assert.IsTrue(vo1 != vo2);
        }

        [TestMethod]
        [TestCategory("ValueObject - Core")]
        public void Deve_ser_diferente_se_valor_diferente()
        {
            var vo1 = new ObjetoValor("Name", 10);
            var vo2 = new ObjetoValor("Name", 11);

            Assert.AreNotEqual(vo1, vo2);
            Assert.IsTrue(vo1 != vo2);
        }
    }
}
