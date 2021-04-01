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

        public Task<List<GameResult>> GetGameResultAsync()
        {
            // DB에 접근해서 모든 데이터 추출
            List<GameResult> results = _context.GameResults
                                        .OrderByDescending(item => item.Score)
                                        .ToList();
            return Task.FromResult(results);
        }
    }
}
