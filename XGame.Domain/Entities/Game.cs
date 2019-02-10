using System;

namespace XGame.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; }

        public string Name{ get; set; }

        public string Description { get; set; }

        public string Producer { get; set; }

        public string Genero { get; set; }

        public string Website { get; set; }
    }
}
