using SharedKernel.BaseObjects;

namespace SharedKernel.Tests.CoreObjects.Classes
{
    public class Entidade: Entity
    {
        public string Nome { get; private set; }

        public Entidade(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
