# Game Project README

## Project Overview  
This project is a simple 3D game engine demo developed in C# using OpenTK 4.x and .NET 9. It demonstrates real-time rendering with a Phong lighting model, textured 3D objects (cube, pyramid, ground plane), and supports interactive gameplay elements such as camera movement, object pickup, and toggling lights.

The project features a modular structure with components handling rendering, texture loading, camera controls, and user interactions.

---

## Gameplay Instructions  
- **Movement**: `W`, `A`, `S`, `D` keys to move the camera around  
- **Look Around**: Hold right mouse button and move mouse to look  
- **Interact**: Press `E` to pick up nearby objects or toggle light when no object nearby  
- **Exit**: Press `Escape` to quit and release cursor  

---

## Features  
- Interactive first-person camera system  
- Phong lighting for realistic shading  
- Texture mapping for enhanced visuals using loaded PNG files  
- Multiple meshes (cube, pyramid, plane) with per-vertex normals  
- Dynamic light source with toggle  
- Modular classes: Shader, Mesh, TextureLoader, Camera, Interact  
- Resource management and file loading relative to executable for portability  

---

## Building & Running the Project  

### Prerequisites  
- .NET 9 SDK  
- Visual Studio 2022+ or `dotnet` CLI  
- OpenTK 4.x and SixLabors.ImageSharp (installed via NuGet)  

### Setup  
- Place shader files in `/Shaders` folder (e.g., `vertex.glsl`, `fragment.glsl`)  
- Place textures in `/Assets` folder  
- Ensure these folders and files are included in the project with **Copy to Output Directory** set to **PreserveNewest**  

### Build Commands  
- Using Visual Studio: Build and Run (`Ctrl+Shift+B`, `Ctrl+F5`)  
- Using CLI:  

---

## Credits
floor.png:
https://images.pexels.com/photos/172292/pexels-photo-172292.jpeg?cs=srgb&dl=pexels-fwstudio-33348-172292.jpg&fm=jpg&_gl=1*h3yu2f*_ga*MTg2NTAxNTg5LjE3NjE5MTk0OTM.*_ga_8JE65Q40S6*czE3NjE5MTk0OTMkbzEkZzEkdDE3NjE5MTk1OTAkajUxJGwwJGgw
texture.png:
https://images.pexels.com/photos/11403947/pexels-photo-11403947.jpeg?cs=srgb&dl=pexels-chase-yaws-192435414-11403947.jpg&fm=jpg&_gl=1*363qpd*_ga*MTg2NTAxNTg5LjE3NjE5MTk0OTM.*_ga_8JE65Q40S6*czE3NjE5MTk0OTMkbzEkZzEkdDE3NjE5MTk1MDMkajUwJGwwJGgw