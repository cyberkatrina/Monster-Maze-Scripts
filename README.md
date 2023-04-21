# Monster-Maze-Scripts
The C# scripts from my Unity2D Horror RPG Game

Project Overview:
In this Unity2D, top down, horror RPG, the player controls the protagonist who goes into a sewer to look for her cat. She must explore the sewer maze, talk to NPCs, fight off monsters, and pick up lives in order to find her cat.

Download the Mac and/or PC build through itch.io : https://r0seline.itch.io/monstermaze

My Goals for the Project:
-Create a scary and suspenseful atmosphere through lighting that will draw the player into the game.
-Develop a game that uses jump scares in a creative manner.
-Give the player an end goal of collecting her cat after she beats the boss monster.
-Use UI text and dialogue in order to guide the player's experience through the maze successfully.

<img width="729" alt="Screenshot 2022-12-07 at 4 11 58 PM" src="https://user-images.githubusercontent.com/113384816/233703309-ed92c50a-593a-4138-b6f5-41ba2abdef42.png">

My Process:
1.) I added a spotlight around the torch that gets transferred to be around the player upon torch collection. After the player collects the torch from the wall, the player holds the torch in their hand throughout the level; they’re able to light their way and attack enemies with it.

2.) I also implemented UI text instructing the player how to attack, “press spacebar”. This text shows right before they reach the first enemy and doesn't show again for the rest of the game.

3.) The player is able to collect her cat after beating the boss monster. I put an area trigger next to the cat because the code was counting previous dialogue in the game as the cat’s dialogue and the cat was collected too soon. Now the player must talk to the cat before collecting it. I also added congratulating text notifying the player that the cat was found, it disappears after 5 seconds.

4.) I ran into a bug with the template’s PlayerCharacter script starting players off without the full health bar. I figured out that taking out the part of that script where the health points are given the value of the player data health at the start of the game fixed this issue. The player data wasn’t refreshing when the level was, therefore the health bar was also not refreshing.

Game Credits:
Katsiaryna Aliashkevich- Programming Scripts (TorchController Script, PlayCutScene Script, AreaTrigger Script, CatController Script, Cat Trigger Script); as well as the scripts, functionality, and player mechanics for our original prototype that was rescoped.

Caroline Millet- Production management, Level design, Tile map design and implementation, Narrative design &amp; implementation.
Doreen Shi- Concept art, Game assets sprites, Cutscene, Tech art.
Robert Gonzalez- Sound FX, Musical themes, Sound implementation.
Meba Wondwossen- Character Concept Art, Character Portraits, UI Elements, Sprite Sheets, Miscellaneous Assets
Samuelle Buning- Protagonist Concept art, Title Screen, End Screen, Protagonist Sprite Sheets.
