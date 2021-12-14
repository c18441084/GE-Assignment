# Project Title

Name: Niall McNamara

Student Number: C18441084

Class Group: DT211/C

# Description of the project
My project is a game involving in Bus in which you drive through portals to gain points. The game starts off in a mountain terrain with cars and trucks on the other side of the road driving towards you. At the end of the road is a portal that you can drive through to then teleport you to a different terrain.

# Instructions for use
To drive the bus you can use the arrow keys on the keyboard. You can use the up arrow to accelerate forward and the down arrow to reverse backwards. The left and right arrow allow the bus to rotate so you can point the bus in a certain direction. If you collide or hit an object with the bus you can press "R" key to reset and bring you bus back to the start of the road of the current terrain you are on.
Code to make bus move:
```CS
public class BusController : MonoBehaviour {

    //Attributes
    public float rotationSpeed = 180f;
    //How fast the Bus will move
    public int moveSpeed = 20;
    //AudioSource used to play the background music
    public AudioSource audio;

    void Start()
    {
      //Starting the background music
      audio.Play();
    }
  	// Update is called once per frame
  	void Update ()
    {
        //Allowing the user to move the bus
        transform.Translate(0, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
    }
}
```
You are also trying to avoid objects to not lose health.

# How it works
When the Bus spawns at the start of the game(with some background music playing), your goal is to go through as many portals as possible before running out of health. Each portal is located at the end of each terrain road. Once you go through the portal, a point is added to your portal points which is found in the top left of the screen. There is also a high score in the the top left of the screen which is the highest amount of portal points a player has gotten. In between the player's bus and the portal are vehicles coming down the other side of the road. If the player hits the vehicles it will cause them to lose some health, depending on which vehicle they collide with. If the player collides with a Car, they will only lose a value of 10 off their total health, however if they collide with the truck, they will lose a total of 30 health. In the BusHealth script I use a coroutine to have a break of a second after impact with the car or lorry to prevent a constant loss of health.
```CS
if(collision.gameObject.name == "Car")
{
  //If the cartriggered is false it enters the statement
  //This true and false method is used to keep the bus constantly reducing health when it triggers with on object
  if(cartriggered == false)
  {
      //Setting cartriggered to true so that it doesn't enter the statement again
      cartriggered = true;
      //Calling the coroutine function
      StartCoroutine(Car());
  }
}

//------------------------------------------------------------------------------------
//coroutine function for car
IEnumerator Car()
{
    //taking a value of 10 off the player's health
    health = health - 10;
    //Waiting 1 second before setting the cartriggered back to false
    yield return new WaitForSeconds(1);
    cartriggered = false;
}
```
If the user's health is equal to or drops below 30, their health display will start changing between the colours white and red, alerting the user that they are low in health. Once the user runs out of health the application restarts and removes all their portal points. When the Bus collides with another vehicle it makes a certain sound. When it collides with the car it makes a car crashing noise and if it collides with the lorry it makes a truck horn sound. When the vehicles reach the end of the road they spawn back to the top of the road where you need to avoid them again. If the bus collides with either vehicle and he knocks the vehicle over or up in the air, it spawns back to the top of the road. When the bus first spawns in you are in a sunny mountain terrain with a straight road and a disconnected white line splitting the road.<img width="665" alt="mountainexample" src="https://user-images.githubusercontent.com/55545170/146027281-eb5f69fc-999c-40e6-a5d2-dd2d476ca5ca.png">


Code to make the terrain flat for the road:
```CS
//Make a flat part of the terrain
void flat()
	{
		Terrain terrain = GetComponent<Terrain>();
		int Axis_x = terrain.terrainData.heightmapResolution;
		int Axis_z = terrain.terrainData.heightmapResolution;
		float[,] heights = terrain.terrainData.GetHeights(0, 0, Axis_x, Axis_z);

		for (int x = Axis_x / 2 - (terrain_height/2); x < Axis_x / 2 + (terrain_height/2); x++)
		{
				for (int z = Axis_z / 2 - 13; z < Axis_z / 2 + 13; z++)
				{
						heights[x, z] = 0;
				}
		}
		terrain.terrainData.SetHeights(0, 0, heights);
	}
```
When you go through the portal, you teleport to a dessert terrain with dark sky full of stars, with a straight road and bumpy sand dunes on either side of the road. On the sand dunes, you can find cactus scattered across the dessert. Once you reach the portal at the end of the dessert terrain it teleports you back to the mountain terrain. To change the skies of the terrains, I had to import a skybox package off the Unity assets store.<img width="660" alt="dessertexample" src="https://user-images.githubusercontent.com/55545170/146027628-896e983a-1bc7-443d-8a7d-b9892f757ca4.png">


# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| AIMovement.cs | Modified from [skooter500]() |
| BusController.cs | Modified from [skooter500]() |
| BusHealth.cs | Self written |
| CarCrashSound.cs | Self written |
| LorryHornSound.cs | Self written |
| PerlinNoise.cs | From Sean Thomas |
| PortalRotation.cs | Self written |
| TerrainGen.cs | Self written |
| Bus | Self Made |
| Car | Self Made |
| Lorry | Self Made |
| Portal Image | [Portal](https://www.google.com/url?sa=i&url=http%3A%2F%2Fwww.custommapmakers.org%2Fviewtopic.php%3Ft%3D623&psig=AOvVaw2FIK30F6corV9McLrTvUw3&ust=1639608831687000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCPjrr4Kx5PQCFQAAAAAdAAAAABAD) |



# References

1. [Unity video](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwi3ipbYp-P0AhUTlFwKHWPGDpkQFnoECAoQAw&url=https%3A%2F%2Fwww.youtube.com%2Fwatch%3Fv%3Dbh9ArKrPY8w&usg=AOvVaw187xe932AHmTby07YXyxAZ) : Video used to help with my OnCollisionEnter functions.

2. [Unity Tutorial](https://support.unity.com/hc/en-us/articles/206116056-How-do-I-use-an-Audio-Source-in-a-script- ) : Link to help me with my audio files.

# What I am most proud of in the assignment
The area that I am most proud of in the assignment is the knowledge of the unity software and C# I have gained since starting this assignment. When I started this assignment, I struggled with every aspect of software on Unity, since then I have be able learn and understand many functions in Unity such as adding audio files, collisions, coroutines, movement of objects, procedural generation, etc.

# Proposal submitted earlier can go here:
