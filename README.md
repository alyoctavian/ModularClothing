# Unity Modular Clothing Store

![WickedClothingGIF](https://github.com/alyoctavian/modularclothing/assets/33526573/4af83c57-98b2-4bd5-9c09-961ae2cba2e7)

## Summary

This project allows you to create a modular clothing system to customize different body parts of your game characters.

## Setup and prerequisites

Unity version used: 2021.3.2f1

Art assets: The sprites and animations must be created to work seamlessly together for the different body parts.
The current project has a 2D top-down perspective, but the same principle applies to sidescrollers, isometric and even 3D games.

The sprites used in the current project were obtained from: https://limezu.itch.io/moderninteriors
There is also a free demo which can be used as inspiration if you want to make your own assets.
Due to licensing, I cannot attach the sprites and the objects depending on them.

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

### Scripts

#### Customization

[BodyPartAnimator](https://github.com/alyoctavian/ModularClothing/blob/main/Scripts/CustomizationScripts/BodyPartAnimator.cs) - Attached to separate body parts (ex. Hair)

This script is attached to each body part in order to manage the currently animated action and direction.

[CustomizationController](https://github.com/alyoctavian/ModularClothing/blob/main/Scripts/CustomizationScripts/CustomizationController.cs) - Attached to the main character

Used to change or remove the current item of a specific body part.

[InventoryManager](https://github.com/alyoctavian/ModularClothing/blob/main/Scripts/CustomizationScripts/InventoryManager.cs) - Attached to the main character

Used to keep track of what clothing items we currently have, as the items can be purchased, equipped and sold.

#### Player Scripts and Utils

The code inside the PlayerScripts is used for movement. When the player is running or when idle, the script propagates the information to the respective body parts.
The component needs to be attached to the main character, and the references should be assigned accordingly.

![image](https://github.com/alyoctavian/ModularClothing/assets/33526573/00b9ef44-e346-4c7f-90f1-5da099162592)

The Singleton class is used to easier access some components without having to reference gameobjects or setup dependencies.
The [ShopInteract](https://github.com/alyoctavian/ModularClothing/blob/main/Scripts/ShopInteract.cs) script is used to show the button whenever the player walks close to the counter.

#### Scriptable Objects

The concept of scriptable objects as data containers is used in order to create the [CustomizationItem](https://github.com/alyoctavian/ModularClothing/blob/main/ScriptableObjects/BodyPart/CustomizationItem.cs) and to store information like name, price and animations.
After importing this script, simply right-click inside the project window to create a customization item for a body type of your choice. I have attached the Outfit folder for reference.
If you keep the structure of this project, the animations need to be referenced in the specified order.

![image](https://github.com/alyoctavian/ModularClothing/assets/33526573/7f4deeed-0aab-4752-9ce1-a7b960845a4e)

#### UI Scripts

The [ItemDisplay](https://github.com/alyoctavian/ModularClothing/blob/main/Scripts/UI%20Scripts/ItemDisplay.cs) script is used to handle the shop elements the user sees and to allow clicking on the shop buttons.

![image](https://github.com/alyoctavian/ModularClothing/assets/33526573/2fc3af29-830f-4edf-98cc-e29ba07dbbe8)

### Final Words

That's the gist of the project. If you have any questions or enquiries feel free to open an issue on the project and I'll be glad to help.
