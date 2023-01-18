using System.Text.Json.Serialization;
using Vektorel.Business.Abstract;
using Vektorel.Business.Concrete;
using Vektorel.DataAccess.Abstract;
//using Vektorel.DataAccess.Concrete.AdoNet.Repositories;
using Vektorel.DataAccess.Concrete.EntityFramework.Repositories;

namespace Vektorel.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                            .AddJsonOptions(x => 
                                            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // IOC Container operation
            builder.Services.AddSingleton<IProductService, ProductManager>();
            builder.Services.AddSingleton<IProductDal, EfProductRepository>();
            builder.Services.AddSingleton<ICategoryService, CategoryManager>();
            builder.Services.AddSingleton<ICategoryDal, EFCategoryRepository>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}