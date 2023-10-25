# Unity Modular Clothing Store

![WickedClothingGIF](https://github.com/alyoctavian/modularclothing/assets/33526573/4af83c57-98b2-4bd5-9c09-961ae2cba2e7)

## Summary

This project allows you to create a modular clothing system to customize different body parts of your game characters.

### Setup and prerequisites

Unity version used: 2021.3.2f1

Art assets: The sprites and animations must be created to work seamlessly together for the different body parts.
The current project has a 2D top-down perspective, but the same principle applies to sidescrollers, isometric and even 3D games.

The sprites used in the current project were obtained from: https://limezu.itch.io/moderninteriors
There is also a free demo which can be used as inspiration if you want to make your own assets.

### Character Layout

The character is composed of the following body parts, each having attached the [BodyPartAnimator.cs](https://github.com/alyoctavian/ModularClothing/blob/main/Scripts/CustomizationScripts/BodyPartAnimator.cs) component:
* Skin - the main body
* Outfit - shirt and pants
* Hair
* Costume - extra accessories

The character can be set as a Prefab to make things easier to use in the Clothes Store scene.

![image](https://github.com/alyoctavian/ModularClothing/assets/33526573/caa97262-7cb4-487a-9332-29d9a1f695a0)
