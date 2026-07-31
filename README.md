# My Herbalife Journey — Setup

This simple static page shows your Herbalife transformation story.

Setup steps:

1. Create an `images` folder next to `index.html`.
2. Place your photos in `images/` with these filenames (recommended JPG/PNG):
   - `ValentineDaypic.jpg` (your 2001 Valentine photo)
   - `RajaStudio1.jpg` (post-marriage with elder son)
   - `RajaStudio2.jpg` (Raja Studio photo)
   - `MumbaiPic.jpg` (Mumbai before COVID)
   - `FamilyPic.jpg` (latest family pic)
   - `RamaniduStudioPic.jpg` (before Herbalife)
   - `LatestFunctionBeforeHerbalife.jpg` (before Herbalife function photo)

3. Open `index.html` in your browser to preview.

Notes & tips:
- Keep original faces and features unchanged — the page only references and displays your photos.
- For best quality use high-resolution images (at least 1200px on the shortest side).
- If filenames differ, update the `src` attributes in `index.html` accordingly.

If you want, I can also:

- Optimize images for web (lossless/resized copies).
- Generate a printable PDF version of the story.

Running with .NET (optional)
----------------------------

If you have the .NET SDK installed you can run this as a minimal web app that serves the static files from the project root.

1. Install .NET SDK (if needed): https://aka.ms/dotnet/download
2. From the project folder run:

```powershell
cd "c:\Users\ChakradharKonada\HerbalifeJourney"
dotnet run
```

The app listens on the default url (usually http://localhost:5000). Open the URL shown in the console.

If `dotnet run` reports no SDK found, use one of the local preview methods (browser open or VS Code Live Server) described earlier.

