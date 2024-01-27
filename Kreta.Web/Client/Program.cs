using Blazored.LocalStorage;
using Kreta.Web.Client;
using Kreta.Web.Client.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Local storage
builder.Services.AddBlazoredLocalStorage();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

// Kiegészítõ szolgáltatások
builder.Services.ConfigureKretaViewModels();
builder.Services.ConfigureKretaWebServices();
builder.Services.ConfigureHttpCliens();

await builder.Build().RunAsync();
