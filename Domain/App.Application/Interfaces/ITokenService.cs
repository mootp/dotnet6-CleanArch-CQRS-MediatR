namespace App.Application.Interfaces;
public interface ITokenService
{
    string GenerateToken(string username);
}