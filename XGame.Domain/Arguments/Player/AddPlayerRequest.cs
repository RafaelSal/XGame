﻿using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AddPlayerRequest
    {
        public Name Name { get; set; }

        public Email Email { get; set; }

        public string Password { get; set; }

    }
}
