# COM3D2.FaceTypePatcher
A Sybaris Patcher that enables creating of facemods that can work with DLC skins

**Note** While it's primeraly targeted at COM3D2 it is compatible with CM3D2.

The way that COM3D2's default skin menu's load face texture onto the model is that they check face modelname and add a string to it, which results in texture filename that the game is searching for. This means that a face mods must provide face textures for ALL game's skins, including DLC's so as to avoid any errors. This of cource is very inconvenient as this significantly increases mod size and makes support for DLC skins kinda iffy, as this can mean distribution of unmodified textures in order to ensure no errors for the end user.

The FaceTypePatcher aims to avoid all of this noncense, by enabling use of textures that game already has.

A more detailed explanation of how patcher works how to adapt faces to work with it described on the [wiki pahge](https://github.com/Neerhom/COM3D2.FaceTypePatcher/wiki/Making-face-mods-for-FaceTypePatcher)

Pre-requisites:

Sybaris 2.1 or equivalent.
[Mono.Cecil.Inject](https://github.com/denikson/Mono.Cecil.Inject/releases)  (included in the archive)

Installation:

Donwload the archive from [relase page](https://github.com/Neerhom/COM3D2.FaceTypePatcher/releases)

Put contents of Sybaris folder inside Sybaris folder.

For CM3D2 and old sybaris, put the contents of Sybari folder into Sybaris/Loader

you can bug me via twitter https://twitter.com/Neerhom_mod for any questions
