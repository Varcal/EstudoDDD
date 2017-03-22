using SharedKernel.BaseObjects;

namespace SharedKernel.Tests.CoreObjects.Classes
{
    public class ObjetoValor: ValueObject<ObjetoValor>
    {
        public string Nome { get; private set; }
        public int Valor { get; private set; }

        public ObjetoValor(string nome, int valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
