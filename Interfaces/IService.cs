namespace Clinic.Interfaces
{
    public interface IServices<T> where T : class
    {
        List<T> GetAll();

        T GetById(int id);

        void Update(T entity);
    }
}
