var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<User> users = new();
users.Add(new(1,"User 1"));
users.Add(new(2,"User 2"));
users.Add(new(3,"User 3"));


app.MapGet("/users", GetUsers);
app.MapGet("/users/{index}", GetUser);
app.MapPost("/users", PostUser);

app.Run();

async Task
PostUser(User user)
{
    users.Add(user);
}

async Task<List<User>>
GetUsers()
{
    return users;
}

async Task<User>
GetUser(int index)
{
    User user = users.find(user)=>user.id==id);
    return user;
}

public record User(int Id, string Name);


