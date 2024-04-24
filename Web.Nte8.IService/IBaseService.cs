namespace Web.Nte8.IService
{
    public interface IBaseService<TEntity, TVo> where TEntity : class
    {
        public Task<List<TVo>> Query();
    }
}
