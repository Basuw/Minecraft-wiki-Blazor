﻿using Blaze_Or.Components;
using Blaze_Or.Factories;
using Blaze_Or.Models;

namespace Blaze_Or.Services
{
    public class DataApiService : IDataService
    {
        private readonly HttpClient _http;

        public DataApiService(
            HttpClient http)
        {
            _http = http;
        }

        public async Task Add(ItemModel model)
        {
            // Get the item
            var item = ItemFactory.Create(model);

            // Save the data
            //await _http.PostAsJsonAsync("https://localhost:7234/api/Crafting/", item);
            await _http.PostAsJsonAsync("https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/", item);
        }

        public async Task<int> Count()
        {
            //return await _http.GetFromJsonAsync<int>("https://localhost:7234/api/Crafting/count");
            return await _http.GetFromJsonAsync<int>("https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/count");
        }

        public async Task<List<Item>> List(int currentPage, int pageSize)
        {
            //return await _http.GetFromJsonAsync<List<Item>>($"https://localhost:7234/api/Crafting/?currentPage={currentPage}&pageSize={pageSize}");
            return await _http.GetFromJsonAsync<List<Item>>($"https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/?currentPage={currentPage}&pageSize={pageSize}");
        }

        public async Task<Item> GetById(int id)
        {
            //return await _http.GetFromJsonAsync<Item>($"https://localhost:7234/api/Crafting/{id}");
            return await _http.GetFromJsonAsync<Item>($"https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/{id}");
        }

        public async Task Update(int id, ItemModel model)
        {
            // Get the item
            var item = ItemFactory.Create(model);

            //await _http.PutAsJsonAsync($"https://localhost:7234/api/Crafting/{id}", item);
            await _http.PutAsJsonAsync($"https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/{id}", item);
        }

        public async Task Delete(int id)
        {
            //await _http.DeleteAsync($"https://localhost:7234/api/Crafting/{id}");
            await _http.DeleteAsync($"https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/{id}");
        }

        public async Task<List<CraftingRecipe>> GetRecipes()
        {
            //return await _http.GetFromJsonAsync<List<CraftingRecipe>>("https://localhost:7234/api/Crafting/recipe");
            return await _http.GetFromJsonAsync<List<CraftingRecipe>>("https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/recipe");
        }

        public async Task<List<Item>> GetAllItems()
        {
            //return await _http.GetFromJsonAsync<List<Item>>($"https://localhost:7234/api/Crafting/all");
            return await _http.GetFromJsonAsync<List<Item>>($"https://codefirst.iut.uca.fr/containers/container-blazor-web-api-marcchevaldonne/api/Crafting/all");
        }


    }
}
