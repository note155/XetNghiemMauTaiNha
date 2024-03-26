using System.Net;
using Append.Blazor.Printing;
using duanxetnghiem.Components;
using duanxetnghiem.Components.Account;
using duanxetnghiem.Data;
using duanxetnghiem.Hubs;
using duanxetnghiem.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Shared.ketnoi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<IGoiXetNghiem, GoiXetNghiemRepository>();
builder.Services.AddScoped<IBacSi, BacSiRepository>();
builder.Services.AddScoped<IDonXetNghiem, DonXetNghiemRepository>();
builder.Services.AddScoped<IKetQuaXetNghiem, KetQuaXetNghiemRepository>();
builder.Services.AddScoped<ITuChoi, TuChoiRepository>();
builder.Services.AddScoped<IGioHang, GioHangRepository>();
builder.Services.AddScoped<IThanhToan, ThanhToanRepository>();
builder.Services.AddScoped<IPrintingService, PrintingService>();
builder.Services.AddScoped<IChiso, ChisoRepository>();
builder.Services.AddScoped<IMau, MauRepository>();
builder.Services.AddScoped<ITuvan, TuvanRepository>();
builder.Services.AddScoped<IMayXetNghiem, MayXetNghiemRepository>();
builder.Services.AddScoped<IKhoa, KhoaRepository>();
builder.Services.AddScoped<IPhong, PhongRepository>();
builder.Services.AddScoped<IRoomchat, RoomchatRepository>();
builder.Services.AddScoped<IChat, ChatRepository>();
builder.Services.AddScoped<ITinhtrang, TinhgtrangRepository>();
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseAdress").Value)
});
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddMvc();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapHub<ChatHub>("/chathub");
app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();
app.UseAntiforgery();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("v1/swagger.json", "My API V1");
});
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(duanxetnghiem.Client._Imports).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();
app.MapPost("/upload", async ([FromForm] WebAssemblyTicket ticket,
    [FromServices] IWebHostEnvironment env) =>
//[FromServices] BlobServiceClient blobClient) =>
{
    foreach (var file in ticket.Attachments)
    {
        // Save locally
        string safeFileName = WebUtility.HtmlEncode(file.FileName);
        var path = Path.Combine("D:\\khoaluan\\duanxetnghiem\\duanxetnghiem\\duanxetnghiem.Client\\wwwroot\\img", safeFileName);
        await using FileStream fs = new(path, FileMode.Create);
        await file.CopyToAsync(fs);

        // Upload file to blob storage
        //var rand = new Random().Next(10000);
        //var docsContainer = blobClient.GetBlobContainerClient("tickets");
        //await docsContainer.UploadBlobAsync(
        //    $"{rand}_{file.FileName}",
        //    file.OpenReadStream());

        // TODO: Save title, description, image reference to a database
    }
}).DisableAntiforgery();
app.Run();
class WebAssemblyTicket
{

    public IFormFileCollection Attachments { get; set; }
}