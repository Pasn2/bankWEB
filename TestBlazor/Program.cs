using TestBlazor.Components;

var builder = WebApplication.CreateBuilder(args);

// ✅ Konfiguracja usług
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // <- Blazor Server interactivity

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5220") // <- Twój backend
});

var app = builder.Build();

// ✅ Middleware (kolejność ma znaczenie)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 🔒 auth, authorization jeśli masz
// app.UseAuthentication();
// app.UseAuthorization();

// 🛡️ Anti-forgery middleware (MUSI być tu!)
app.UseAntiforgery();

// ✅ Razor Components endpoint
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); // <- interaktywność Blazor Server

app.Run();
