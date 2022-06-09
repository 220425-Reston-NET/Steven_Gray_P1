using ShoeAppBL;
using ShoeAppDL;
using ShoeAppModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepository>(repo => new SQLCustomerRepository(builder.Configuration.GetConnectionString("Steven Gray")));
builder.Services.AddScoped<ICustomerBL, CustomerBL>();
builder.Services.AddScoped<IRepository<Store>, SQLStoreRepository>(repo => new SQLStoreRepository(builder.Configuration.GetConnectionString("Steven Gray")));
builder.Services.AddScoped<IStoreBL, StoreBL>();
builder.Services.AddScoped<IRepository<CustomerInventoryJoin>, SQLCustInvoJoinRepo>(repo => new SQLCustInvoJoinRepo(builder.Configuration.GetConnectionString("Steven Gray")));
builder.Services.AddScoped<ICustInvoJoinBL, CustInvoJoinBL>();
//  builder.Services.AddScoped<IRepository<Customer>>(repo => new (Environment.GetEnvironmentVariable("Connection_String")));
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
