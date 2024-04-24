
using Web.Nte8.IService;
using Web.Nte8.Service;
using Web.Nte8.ServiceExtensions;


namespace Web.Nte8
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //依赖注入
            builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
            AutoMapperConfig.RegisterMappings();

            //依赖注入
            /*
             AddSington：单例模式。

                AddScope：会话模式。一个http请求。

                AddTrasient：瞬时模式。
             */
            builder.Services.AddScoped(typeof(IBaserepository<>), typeof(Baserepository<>));
            builder.Services.AddScoped(typeof(IBaseService<,>) , typeof(BaseService<,>));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
