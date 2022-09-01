var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
// Khi chưa cầu hình dùng js để gọi API nó sẽ báo lỗi CORS vì js cùng là localhost nhưng khác port nên nó sẽ không gọi được API của backend
// Cần phải cấu hình để bỏ qua việc chặn CORS đó 