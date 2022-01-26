using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blazor_training.Client;
using blazor_training.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Dependency Injections
builder.Services.AddSingleton<ServiceExampleSingleton>();
builder.Services.AddTransient<ServiceExampleTransient>();

await builder.Build().RunAsync();
