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

### Creating the animations

First of all, when importing the sprite sheets, the following settings were applied to the texture files:

![image](https://github.com/alyoctavian/ModularClothing/assets/33526573/4406c513-f0c2-4da2-96a4-be0fd382909f)

When slicing the sprite sheet, the following settings were used in order to make sure that each body part overlaps seamlessly and they all work nicely together. In this case, I preferred to pivot the sprites to the bottom.

![image](https://github.com/alyoctavian/ModularClothing/assets/33526573/65c659b4-e1f9-4876-89f7-bef870c9589f)

Each animation is characterized by the action (ex. idle) and the direction (ex. right).
Each item has its own animator controller and set of animations. This means that if you have 5 different hairstyles, there would be 5 separate animators each with the corresponding set of animations for the actions that you want to implement.
In this project, we have animations for idle and run, therefore an animator looks like this:

![image](https://github.com/alyoctavian/ModularClothing/assets/33526573/eb2ab3b7-58d7-4bfc-a700-ab082a32a0e6)

