using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve static files (index.html, styles.css, images) from project root
var contentRoot = Directory.GetCurrentDirectory();
var provider = new PhysicalFileProvider(contentRoot);

var defaultFilesOptions = new DefaultFilesOptions
{
    FileProvider = provider
};
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("index.html");

app.UseDefaultFiles(defaultFilesOptions);
app.UseStaticFiles(new StaticFileOptions { FileProvider = provider });

app.MapGet("/health", () => Results.Text("OK"));

app.Run();
