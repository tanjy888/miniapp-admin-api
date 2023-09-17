var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
{
    #region 配置swagger
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "阳光剧场 WebApi 接口文档",
        Description = "提供给H5小程序管理后台的前端调用WebAPI接口",
   });
    #endregion

    #region 配置展示注释
    {
        var path = Path.Combine(AppContext.BaseDirectory, "WebApplication3.xml");  // xml文档绝对路径
        c.IncludeXmlComments(path, true); // true : 显示控制器层注释
        c.OrderActionsBy(o => o.RelativePath); // 对action的名称进行排序，如果有多个，就可以看见效果了。

    }
    #endregion
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint($"/swagger/v1/swagger.json", $"app v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
