using AutoMapper;
using Newtonsoft.Json;
using Web.Nte8.IService;

namespace Web.Nte8.Service
{
    public class BaseService<TEntity, TVo> : IBaseService<TEntity, TVo> where TEntity : class, new()
    {
        private readonly IMapper _mapper;
        private readonly IBaserepository<TEntity> _baseRepository;

        public BaseService(IMapper mapper, IBaserepository<TEntity> baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }

        /// <summary>
        ///查询，方法，
        /// </summary>
        /// <returns></returns>
        public async Task<List<TVo>> Query()
        {
            var entities = await _baseRepository.Query();
            var llout = _mapper.Map<List<TVo>>(entities);
            return llout;
        }
    }
}
