using System;
using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        string AutenticatePlayer(string email, string senha);

        Guid AddPlayer(AddPlayerRequest request);
    }
}
