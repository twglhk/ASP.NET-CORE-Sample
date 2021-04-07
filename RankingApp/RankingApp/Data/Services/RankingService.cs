﻿using Newtonsoft.Json;
using SharedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RankingApp.Data.Services
{
    public class RankingService
    {
        HttpClient _httpClient;

        public RankingService(HttpClient client)
        {
            _httpClient = client;
        }

        /* CRUD */
        //Create
        public async Task<GameResult> AddGameResult(GameResult gameResult)
        {
            var jsonStr = JsonConvert.SerializeObject(gameResult);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("api/ranking", content);

            if (result.IsSuccessStatusCode == false)
                throw new Exception("AddGameResult Failed");

            var resultContent = await result.Content.ReadAsStringAsync();
            var resGameResult = JsonConvert.DeserializeObject<GameResult>(resultContent);
            return resGameResult;
        }

        //Read
        public async Task<List<GameResult>> GetGameResultAsync()
        {
            var result = await _httpClient.GetAsync("api/ranking");
            var resultContent = await result.Content.ReadAsStringAsync();
            var resGameResults = JsonConvert.DeserializeObject<List<GameResult>>(resultContent);
            return resGameResults;
        }

        //Update
        public async Task<bool> UpdateGameResult(GameResult gameResult)
        {
            var jsonStr = JsonConvert.SerializeObject(gameResult);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("api/ranking", content);

            if (result.IsSuccessStatusCode == false)
                throw new Exception("UpdateGameResult Failed");

            return true;
        }

        //Delete
        public async Task<bool> DeleteGameResult(GameResult gameResult)
        {
            var result = await _httpClient.DeleteAsync($"api/ranking/{gameResult.Id}");

            if (result.IsSuccessStatusCode == false)
                throw new Exception("UpdateGameResult Failed");

            return true;
        }
    }
}
