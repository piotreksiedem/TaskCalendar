var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
options.AddPolicy(name: "MyAllowSpecificOrigins",
builder =>
{
    builder.WithOrigins("https://localhost:7065");
}
))
    ;
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Task Calendar",
        Version = "v1",
        Description = "Application for tasking",
    });
    //var filePatch = Path.Combine(AppContext.BaseDirectory, "TaskCalendar.xml");
    //c.IncludeXmlComments(filePatch);
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
