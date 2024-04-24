
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

            //����ע��
            builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
            AutoMapperConfig.RegisterMappings();

            //����ע��
            /*
             AddSington������ģʽ��

                AddScope���Ựģʽ��һ��http����

                AddTrasient��˲ʱģʽ��
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
