using MercadoMagico.Data;
using MercadoMagico.Handlers;
using MercadoMagico.Repositorios;
using MercadoMagico.Repositorios.InstrumentoMagico;
using MercadoMagico.Repositorios.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mercadinho do Magão", Version = "v1" });

            c.AddSecurityDefinition("Basic", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.Http,
                Scheme = "basic",
                Description = "Autenticação básica (email e senha)"
            });

            // Configure o esquema de segurança para usar nas operações (métodos)
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Basic"
                        }
                    },
                    new string[] { }
                }
            });
        });

        builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
        builder.Services.AddScoped<IInstrumentoMagicoRepositorio, InstrumentoMagicoRepositorio>();
        builder.Services.AddScoped<IInstrumentoMagicoEstatistica, InstrumentoMagicoEstatistica>();
        builder.Services.AddScoped<IInstrumentoMagicoBusca, InstrumentoMagicoBusca>();
        builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

        builder.Services.AddAuthentication("BasicAuthentication")
            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}