var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá Pessoal");


app.MapPost("/login", (minimal_api.Dominio.DTOs.LoginDTO loginDTO) =>
{
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
        return Results.Ok("Login efetuado");
    else
    
        return Results.Unauthorized();
    
});




app.Run();

public class LoginDTO
{
    public string Email { get; set; } = default;
    public string Senha { get; set; } = default;
}