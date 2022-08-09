using API.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Client.Pages
{
    public partial class Shops
    {
        private List<ShopModel> Shop = new();
        [Inject] private HttpClient HttpClient { get; set; }
        [Inject] private IConfiguration Config { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var result = await HttpClient.GetAsync(Config["apiUrl"] + "/api/Shop");
            if (result.IsSuccessStatusCode)
            {
                Shop = await result.Content.ReadFromJsonAsync<List<ShopModel>>();
            }
        }
    }
}
