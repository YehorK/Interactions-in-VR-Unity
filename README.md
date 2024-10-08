# Lab2 Assignment
This project is done as part of the Lab 1 assignment for IMTC 505 course.
Unity 2022.3.46f1 is used.

The scene is constructed with the Halloween theme, using thwe following assets pack: https://assetstore.unity.com/packages/3d/props/poly-halloween-236625

<img src="Images/scene.png" alt="scene view" width="600" height="400">
 
## Description
The goal of this project was to implement several interactive elements within VR and to be able to interact with them. Please refer to the Table of Content an d the subsequest sections for further details. As for the VR headset - Meta Quest 2 was used for debugging and the final application deployment.

## Video Demo
The video demonstrates all of the created elements in the project:

[![Lab 2 Assignment Video Demo](https://img.https://youtu.be/S62Rw_BuyLM/0.jpg)](https://youtu.be/S62Rw_BuyLM)

## Table of Contents
- [Animation](#animation)
- [Gaze based](#gaze)
- [Grabbable](#Grabbable)
- [UI slider](#UI-slider)
- [Teleportation](#teleportation)
- [Main challenges](#main-challenges)
- [Useful Tutorials](#useful-tutorials)


## Animation
A gates opening animation is implemented. An invisible box collider is added that is triggered when a player apporaches the gates. The door opening animation is played only once during the runtime. 

<img src="Images/gates_animation.png" alt="Gates Opening Animation" width="600" height="300">


## Gaze
Gaze based interactions in this demo are showecased through the candles lighting. Specifically, one carved pumpkin, and spine & skull candles lit up when player's gaze at these objects is detected. 

<img src="Images/gaze.png" alt="Gaze Interactions" width="600" height="300">


## Grabbable
Ability to grab objects seems essential. Therefore, in this demo a small pupkin is spawned on the stone in the middle of the scene - it can be picked up and thrown by the player. If the position of the pumpkin is altered (from its origin) and it hasn't been moved for 5 seconds - it destroys and re-spawns. Similarly, if the player manages to throw it outside of the gameplay area - it will re-spawn. 

<img src="Images/grabbable.png" alt="Grabbable Object" width="600" height="300">

One of the interesting interactions with this pumpkin is that after hitting the cauldron in the scene 5 times, it will lit up (or i.e. it will turn from empty to full of potion).

<img src="Images/cauldron.png" alt="Grabbable Object" width="600" height="300">

## UI slider

In order to understand how2 the basic UI elements can be used within the VR scene, this slider UI is added to the scene. It allows to rotate the scarecrow for 180 degrees to either side.

<img src="Images/slider_UI.png" alt="Grabbable Object" width="600" height="300">

## Teleportation

Teleportation was added as well as the whole Locomotion system. In terms of the teleportation area - it is limited only within the walls of the scene. When choosing the place to teleport to, the player can also adjust with joystick the direction they wish facing when teleported.

<img src="Images/teleportation.png" alt="Grabbable Object" width="600" height="300">

## Main challenges
- Locomotion system
- Animation (characters)


## Useful Tutorials:
As part of the assignment, I'd like to acknowledge the following tutorials that were very helpful in the learning process: 
- https://www.youtube.com/watch?v=cxRnK8aIUSI
- https://www.youtube.com/watch?v=8xIxXkXn26M
- https://www.youtube.com/watch?v=SfQS9lfRRm0
- https://www.youtube.com/watch?v=yhB921bDLYA
- https://www.youtube.com/watch?v=dZQYMNXojOs&t
