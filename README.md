# Project Title

Name: Niall McNamara

Student Number: C18441084

Class Group: DT211/C

# Description of the project
My project is a game involving in Bus in which you drive through portals to gain points. The game starts off in a mountain terrain with cars and trucks on the other side of the road driving towards you. At the end of the road is a portal that you can drive through to then teleport you to a different terrain.

# Instructions for use
To drive the bus you can use the arrow keys on the keyboard. You can use the up arrow to accelerate forward and the down arrow to reverse backwards. The left and right arrow allow the bus to rotate so you can point the bus in a certain direction. If you collide or hit an object with the bus you can press "R" key to reset and bring you bus back to the start of the road of the current terrain you are on. You are also trying to avoid objects to not lose health.

# How it works
When the Bus spawns at the start of the game(with some background music playing), your goal is to go through as many portals as possible before running out of health. Each portal is located at the end of each terrain road. Once you go through the portal, a point is added to your portal points which is found in the top left of the screen. In between the player's bus and the portal are vehicles coming down the other side of the road. If the player hits the vehicles it will cause them to lose some health, depending on which vehicle they collide with. If the player collides with a Car, they will only lose a value of 10 off their total health, however if they collide with the truck, they will lose a total of 30 health. If the user's health is equal to or drops below 30, their health display will start changing between the colours white and red, alerting the user that they are low in health. Once the user runs out of health the application restarts and removes all their portal points. When the Bus collides with another vehicle it makes a certain sound. When it collides with the car it makes a car crashing noise and if it collides with the lorry it makes a truck horn sound. When the vehicles reach the end of the road they spawn back to the top of the road where you need to avoid them again. If the bus collides with either vehicle and he knocks the vehicle over or up in the air, it spawns back to the top of the road. When the bus first spawns in you are in a sunny mountain terrain with a straight road and a disconnected white line splitting the road. Which you go through the portal, you teleport to a dessert terrain with dark sky full of stars, with a straight road and bumpy sand dunes on either side of the road. On the sand dunes, you can find cactus scattered across the dessert.

# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| MyClass.cs | Self written |
| MyClass1.cs | Modified from [reference]() |
| MyClass2.cs | From [reference]() |

# References

# What I am most proud of in the assignment

# Proposal submitted earlier can go here:

## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |