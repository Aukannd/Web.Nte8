using Newtonsoft.Json;

namespace Web.Nte8.Service
{
    public class Baserepository<TEntity> : IBaserepository<TEntity> where TEntity : class, new()
    {
        public async Task<List<TEntity>> Query()
        {
            /*模拟数据库操作*/
            await Task.CompletedTask;
            var data = "[{\"Id\":18,\"Name\":\"namename\"}]";
            return JsonConvert.DeserializeObject<List<TEntity>>(data) ?? new List<TEntity>();
        }
    }
}
