# FontReplace
A mod for [Pathfinder: Kingmaker](https://kingmaker.owlcatgames.com/) game to replace the default font.

## Install
1. Install the [Unity Mod Manager](https://www.nexusmods.com/site/mods/21/)
2. Install the mod using the Unity Mod Manager
3. Open the Unity Mod Manager (CTRL + F10) and ensure the mod is loaded
    
## Build
1. Install [.NET Core SDK](https://dotnet.microsoft.com/download)
2. Install [.NET Framework Dev pack v4.6](https://dotnet.microsoft.com/download)
3. Rename & configure the `FontReplace.csproj.user` to target the game directory
3. `dotnet build`
4. `dotnet msbuild -t Test` to install mod & run the game
5. `dotnet msbuild -t Pack` to generate zip for Unity Mod Manager
