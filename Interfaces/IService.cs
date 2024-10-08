namespace Clinic.Interfaces
{
    public interface IServices<T> where T : class
    {
        T GetById(int id);

        void Update(T entity);
    }
}
