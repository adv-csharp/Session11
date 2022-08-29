namespace _2_di.Services
{
    public interface ICrud<T>
    {
        void Create(T model);
        void Detele(int id);
        List<T> Read();
        void Update(T model);
    }
}