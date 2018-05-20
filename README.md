# COM3D2.FaceTypePatcher
A Sybaris Patcher that enables creating of facemods that can work with DLC skins
**Note** While it's primeraly targeted for COM3D2 it is compatible with CM3D2.

The way that COM3D2's default skin menu's load face texture onto the model is that they check face modelname and add a string to it, which results in texture filename that the game is searching for. This means that a face mods must provide face textures for ALL game's skins, including DLC's so as to avoid any errors. This of cource is very inconvenient as this significantly increases mod size and makes support for DLC skins kinda iffy, as this can mean distribution of unmodified textures in order to ensure no errors for the end user.

The FaceTypePatcher aims to avoid all of this noncense, by enabling use of textures that game already has.

The way patcher operates is that it reads the model filename and searches for **facetype** in the filename and if filename has it, it then looks for 3 characters after the **facetype** and dervies which texture of game's face to load.

For instance, the game has a face model called  **face004.model** and a set of textures for it called face004*.tex.
So if you want your face mod to use those textures for default and DLC skins then modelfilename must contain **facetype** and the next 3 characters must be **004** because three numbers after **face** is what considered to be a facetype.

So in this case you model name must contain **facetype004** for it to use textures of face004.model, when a default skin menu tries to load a texture on it. For instance yor model filename can be **facetype004myface.model** or **myfacefacetype004.model** both cases are valid and will result in your face model to use skin texture of face004.model

Pre-requisites:

Sybaris 2.1 or equivalent.
[Mono.Cecil.Inject](https://github.com/denikson/Mono.Cecil.Inject/releases)  (included in the archive)

Installation:

Donwload the archive from [relase page](https://github.com/Neerhom/COM3D2.FaceTypePatcher/releases)

Put contents of Sybaris folder inside Sybaris folder.

For CM3D2 and old sybaris, put the contents of Sybari folder into Sybaris/Loader

you can bug me via twitter https://twitter.com/Neerhom_mod for any questions
