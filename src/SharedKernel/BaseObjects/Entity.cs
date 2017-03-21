using System;

namespace SharedKernel.BaseObjects
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        public DateTime DataCadastro { get; private set; }  
        public bool Ativo { get; protected set; }


        protected Entity()
        {
            DataCadastro = DateTime.Now;
        }

        public void Ativar()
        {
            Ativo = true;
        }

        public void Desativar()
        {
            Ativo = false;
        }


        #region Overrides
        public override bool Equals(object entity)
        {
            var entityTmp = entity as Entity;

            if (ReferenceEquals(entityTmp, null))
                return false;

            if (ReferenceEquals(this, entityTmp))
                return true;

            if (GetType() != entityTmp.GetType())
                return false;

            if (Id == 0 || entityTmp.Id == 0)
                return false;

            return Id == entityTmp.Id;
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }

        public static bool operator ==(Entity entityA, Entity entityB)
        {
            if (ReferenceEquals(entityA, null) && ReferenceEquals(entityB, null))
                return true;

            if (ReferenceEquals(entityA, null) || ReferenceEquals(entityB, null))
                return false;

            return entityA.Equals(entityB);
        }

        public static bool operator !=(Entity entityA, Entity entityB)
        {
            return !(entityA == entityB);
        } 
        #endregion
    }
}
