namespace Data.Transactions
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void RollBack();
        void Save();
    }
}
