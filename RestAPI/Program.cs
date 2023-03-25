using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ITopicDataAccess, TopicDAO>();
builder.Services.AddSingleton<IPostDataAccess, PostDAO>();
builder.Services.AddSingleton<IPersonDataAccess, PersonDAO>();
builder.Services.AddSingleton<ICommentDataAccess, CommentDAO>();
builder.Services.AddMvc();
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
