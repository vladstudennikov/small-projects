namespace DAL
{
    public interface IDataProvider<T>
    {
        void Write(T data, string link);
        T Read(string link);
    }
}
