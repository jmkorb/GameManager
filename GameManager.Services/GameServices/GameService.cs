using GameManager.Data;
using GameManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Services
{
    public class GameService
    {
        {
        private readonly int _userId;

        public GameService(int userId)
        {
            _userId = userId;
        }

        public bool CreateGame(GameCreate model)
        {
            var entity =
                new Game()
                {
                    Id = _userId,
                    Title = model.Title,
                    Description = model.Description,
                    YearOfRelease = model.YearOfRelease,
                    Genre = model.Genre,
                    IfPlayed = model.IfPlayed,
                    Rating = model.Rating,
                    GameSystem = model.GameSystem
                };
            using (var ctx = new ApplicationDbContext())
            {

            }
        }
    }
}
    
}
