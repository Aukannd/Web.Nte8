namespace Web.Nte8.Service
{
    public interface IBaserepository<TEntity> where TEntity : class
    {
        //  泛型基类接口
        public Task<List<TEntity>> Query();
    }
}
