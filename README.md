Mini-Project
Project Name: Sly Cooper But Worse
Name: Markus Engel Møller
Student Number: 20233899
Github Link to Project: https://github.com/Markus-markmus/Sly-Cooper-But-Worse.git 

Overview of the Game:
This project is based on the Sony owned IP Sly Cooper. It takes inspiration from many different iterations of the series, where the main idea is of a 3D platformer, with mild parkour elements, as well as collectible hunting. The level design takes inspiration from the third game in the series, while the simplistic gameplay style takes inspiration from the very first game. In this simplistic game, the goal is to get all the clue bottles all while avoiding the guard on the floor.
How to Play:
The game is set up with the Unity Input System, which means it has multiple input options.
Controller:
•	MOVE:
o	Left Analogue stick
•	CAMERA:
o	Right Analogue stick
•	JUMP/DOUBLE JUMP:
o	South Button
•	SPRINT: 
o	Left Trigger
•	RESTART:
o	East Button
Keyboard/Mouse:
•	MOVE:
o	WASD [Keyboard]
•	CAMERA:
o	Mouse–
•	JUMP/DOUBLE JUMP:
o	Space bar [Keyboard]
•	SPRINT: 
o	Left Shift [Keyboard]
•	RESTART:
o	R [Keyboard]
Main parts of the game:
•	Player - Sly, controlled with either WASD or left analogue stick from controller.
•	Camera - Pivoted around Sly and can be moved around in 360degrees with either mouse or right analogue stick from controller.
•	Enemy - one singular guard patrolling the floor level, incentivising altitude.
•	Clue Bottles - What the game wants you to get to complete it.
•	Tracker - A GUI keeps track of how many clue bottles have been collected.
•	Master Thieving Opportunities - Blue sparkles indicate  possible ways to go.

The Process:
First the level was greyboxed with Probuilder for the environment and capsules for the player and guard. After numerous hours of getting a janky thirdperson camera to work, I found the Unity StarterAssets pack that included a premade ThirdPersonController. I then tweaked the script to allow me to double jump. Then I found character models online and animated them with the help of Mixamo. I took those Mixamo Anims and shifted them out with the prepackaged ones from the StarterAsset. Dimitri(the guard) couldn’t load his anims and after countless tries I gave up. He does however work with Navmesh and patrols the ground. I then added blue sparkles with the particle system to ensure that players knew that they could jump on spiky platforms and ropelines. There was also supposed to be a climb ability on the pole, but time constraints stopped me. I then found a bottle prefab and hid them throughout the level to give the player an objective. Groovy music and disco lights, and the game was a go.

Project Parts:
•	Scripts:
o	ThirdPersonController - In charge of all player movement, Third person controller as well.
o	StarterAssetsInputs - Also in charge of player movement, but specifically in charge of Input management.
o	GuardAI - uses Navmesh to ensure the guard patrols
o	RandomLightToggle - Toggles the lights on/off to give that groovy disco feel.
o	RestartInputHandler - Created to let the player used ‘R’ on keyboard or ‘East Button’ on Gamepad when prompting the game to restart.
o	GameManager - Manages the RestartGame() method that both GuardDetection & BottleCollector uses
o	GuardDetection - Checks whether the player collides with the guards light, and if so gives a game over screen that prompts a restart.
o	BottleCollector - Lets player collide and destroy bottles, adds them up on a tally with a GUI and then gives a game complete canvas if 10 bottles are reached. Also prompts restart.
•	Assets:
o	https://assetstore.unity.com/packages/essentials/starter-assets-thirdperson-updates-in-new-charactercontroller-pa-196526 - Third person controller - Unity Technologies
o	https://www.mixamo.com/#/ - Premade animations - Mixamo
o	https://www.slycoopernet.com/downloads.html - Sly Cooper Thieves in Time 3D Model via Slycoopernet
o	https://www.deviantart.com/sab64/art/MMD-FBX-Model-Dimitri-Lousteau-Download-866096952 - Dimitri Lousteau 3D model - SAB64 via DeviantArt
o	Bottle by Don Carson [CC-BY] via Poly Pizza
o	https://www.youtube.com/watch?v=IJGdr1zHMUE - Sly 2: Band of Thieves - Job Failed!/Green Screen - Jiggly
o	https://www.reddit.com/media?url=https%3A%2F%2Fpreview.redd.it%2Fm1rulh7x13t51.jpg%3Fwidth%3D1080%26crop%3Dsmart%26auto%3Dwebp%26s%3D03e9965677bc19d85d15bc78a8252342cc081936 - Sly 2: Band of Thieves Job Completed

•	Materials:
o	Basic Unity Materials for purely colored objects.
o	https://assetstore.unity.com/packages/2d/textures-materials/wood/stylized-wood-texture-153499 - Stylized Wood Texture - LowlyPoly

•	Scenes:
o	Game consist of one scene.

•	Testing:
o	Game was tested on Windows with both Keyboard/Mouse and PS5 Controller.

Time Management:
Task	Time it Took (in hours)
Setting up Unity, making a project in GitHub	0.5
Research and conceptualization of game idea	2
Searching for 3D models - Sly Cooper, Dimitri, Clue Bottles	0.5
Applying Mixamo animations to Unity	1.5
Making camera movement controls and initial testing	2
Making failed third person player controls	2
Making Unity’s StarterAssets (ThirdPersonController) work in project	1
Creating Thieving sparks with Particle system.	1
Creating collectible bottle functionality	1.5
Creating Guard AI pattern	2
Making UI elements and research into TextMesh Pro	1.5
Implementing Job Failed/completed and restart method	1
Code documentation	1
Making readme (report)	1
All	18.5


Used Resources:
Tutorials:
•	https://www.youtube.com/watch?v=c8Nq19gkNfs&ab_channel=LofiDev - Patrolling AI in Unity with C# - Lofi Dev
•	https://www.youtube.com/watch?v=77IvdSD_oUI - Particle Effects in Unity - 
make100games
•	Starter Assets overview | Unity - Changing Avatar in Starter Assets - Unity
•	https://www.youtube.com/watch?v=6iSJ_jh6Rdo - How to Collect Coins in Unity 3D Tutorial 2023 - Rigor Mortis Tortoise 
