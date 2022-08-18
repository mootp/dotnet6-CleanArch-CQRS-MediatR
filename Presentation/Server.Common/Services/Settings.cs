using App.Application.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Server.Common.Services;
public class Settings : ISettings
{
    private readonly IConfiguration _configuration;

    public Settings(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string TokenKey { get => _configuration["JwtSecret"]; }
}