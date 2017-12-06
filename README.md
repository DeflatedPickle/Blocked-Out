# Stuck-In-Trouble
A claustrophobic puzzle game about getting out of a cube.

## What Each Languages Does:
### C#:
C# is the main language of the game. It is used for main scripts, scrips that attach to objects and loading the other languages.

### Python:
Python is used for scripts that need to use C# code. Mods will also be written in Python.

### Lua:
Lua is used for scripts that do not need to use C#.

## Level Concept:
```json
{
    "name": "MyLevel",
    "background": "green",
    "tiles": [
        ["x", "x", "x", "x", "x", "x", "x", "x"],
        ["x", "x", " ", " ", " ", " ", " ", "x"],
        ["x", " ", " ", " ", " ", " ", " ", "x"],
        ["x", " ", " ", " ", " ", "x", "x", "x"],
        ["x", " ", " ", " ", " ", " ", "x", "x"],
        ["x", "x", " ", " ", " ", " ", " ", "x"],
        ["x", "x", "x", " ", " ", " ", " ", "x"],
        ["x", "x", "x", "x", "x", "x", "x", "x"],
    ],
    "block": "x",
    "air": " ",
}
```

## Required Packages:
- [2D Dynamic Lights and Shadows](https://assetstore.unity.com/packages/tools/particles-effects/2d-dynamic-lights-and-shadows-24083)