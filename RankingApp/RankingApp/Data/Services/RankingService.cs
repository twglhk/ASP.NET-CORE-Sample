using RankingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankingApp.Data.Services
{
    public class RankingService
    {
        ApplicationDbContext _context;

        public RankingService(ApplicationDbContext context)
        {
            _context = context;
        }

        /* CRUD */
        //Create
        public Task<GameResult> AddGameResult(GameResult gameResult)
        {
            _context.GameResults.Add(gameResult); // memory save
            _context.SaveChanges(); // DB save

            return Task.FromResult(gameResult);
        }

        //Read
        public Task<List<GameResult>> GetGameResultAsync()
        {
            // DB에 접근해서 모든 데이터 추출
            List<GameResult> results = _context.GameResults
                                        .OrderByDescending(item => item.Score)
                                        .ToList();
            return Task.FromResult(results);
        }

        //Update

        //Delete
    }
}
