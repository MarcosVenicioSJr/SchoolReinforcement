namespace SchoolReinforcement.Interfaces.Repository
{
    public interface IRepository <T> where T : class
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        void Create(T entity);
    }
}
