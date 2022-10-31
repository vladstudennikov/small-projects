namespace DAL
{
    interface IDataContext<T>
    {
        string Link { get; }
        IDataProvider<T> DataProvider { get; set; }
        T GetData();
        void SetData(T data);
    }
}
