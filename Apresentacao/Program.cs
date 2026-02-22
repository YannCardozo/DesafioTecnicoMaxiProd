using Dominio.Entidades;
using Dominio.Interfaces;
using InfraData.Context;
using InfraData.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//se sobrar tempo separar extensions depois e chamar tudo aqui em program.cs


//para TESTES com banco em memoria
//var connection = new SqliteConnection("DataSource=:memory:");
//connection.Open();
//builder.Services.AddDbContext<ContextPrincipal>(options =>
//{
//    options.UseSqlite(connection);
//});



var StringConexao = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ContextPrincipal>(opt => opt.UseSqlServer(StringConexao));
builder.Services
    .AddIdentity<Usuario, IdentityRole<Guid>>(opts =>
    {
        opts.Password.RequireDigit = true;
        opts.Password.RequireUppercase = true;
        opts.Password.RequiredLength = 6;
    })
    .AddEntityFrameworkStores<ContextPrincipal>()
    .AddDefaultTokenProviders();

//injecao de dependencia do repository pattern.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<CategoriasRepository>();
builder.Services.AddScoped<PessoasRepository>();
builder.Services.AddScoped<TransacoesRepository>();
builder.Services.AddSwaggerGen();
var app = builder.Build();

//ambiente de teste simulado no sqlite
//using (var scope = app.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<ContextPrincipal>();
//    db.Database.EnsureCreated();
//    //apagar de vez em quando para limpar o cache de memoria.
//    //db.Database.EnsureDeleted();
//}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
