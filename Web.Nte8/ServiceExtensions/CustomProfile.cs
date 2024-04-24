using AutoMapper;
using System.Data;
using Web.Nte8.Model;

namespace Web.Nte8.ServiceExtensions
{
    public class CustomProfile: Profile
    {
        public CustomProfile()
        {
            //关系映射
            CreateMap<Role, RoleVo>().ForMember(a => a.RoleName, o => o.MapFrom(d => d.Name));
            CreateMap<RoleVo, Role>().ForMember(a => a.Name, o => o.MapFrom(d => d.RoleName));
        }
    }
}
