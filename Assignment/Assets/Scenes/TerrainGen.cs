using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrainGen : MonoBehaviour
{
  //Attributes
  public Text showpoints;
  public Text High;
  public int speedlimit = 40;
  public int counter = 0;
  public int i = 235;
  public int points = 0;
  public string hs;
  public int highscore = 0;
  public int alertscorebeaten = 0;
  public int scorebeaten = 0;
  //public PerlinNoise ground;
  public Material Mountain_sky;
  public Material Dessert_sky;
  public GameObject Car;
  public GameObject Bus;
  public GameObject Lorry;
  public Terrain Dessert;
  public Terrain Mountain;
  private Light[] lights;

    // Start is called before the first frame update
    void Start()
    {
      //Changes the sky to a blue sky
      RenderSettings.skybox = Mountain_sky;
      //Array
      lights = FindObjectsOfType(typeof(Light)) as Light[];

      GetComponent<Rigidbody>();
      //Getting the value of the current highscore
      /*The two lines commited out below are used to reset the highscore*/
      //PlayerPrefs.SetInt(hs, 0);
      //PlayerPrefs.Save();
      highscore = PlayerPrefs.GetInt(hs, 0);

      Car.transform.position = new Vector3(135, 2, i-100);
      Car.transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
      //Displaying the Score of the current game
      showpoints.text = "Portal Points: " + points;

      //Displaying the highest score
      High.text = "Highscore: " + highscore;
      //Changing the highscore if it is beaten
      if(points > highscore)
      {
        //Setting the new highscore
        PlayerPrefs.SetInt(hs, points);
        //Saving the high score
        PlayerPrefs.Save();
        highscore = PlayerPrefs.GetInt(hs, points);
        //Setting scorebeaten to 1 to start coroutine
        scorebeaten = 1;
      }

      if(scorebeaten == 1)
      {
        //Starting the coroutine
        StartCoroutine(ScoreBeaten());
      }

      //IF statement to use when the bus goes past the 'i' limit of the 'z' axis
      if(Bus.transform.position.z>(i))
      {
        //Adding a point onto the total everytime the Bus goes through the portal
        points++;
        //If counter equals zero it generates the mountain terrain
        if(counter == 0){
          //Loop used to change the light when the bus enters the dessert
          foreach(Light light in lights)
          {
            light.intensity = 0;
          }
          //Moving the dessert terrain into the position for the bus to land on
          Dessert.transform.position = new Vector3(0, -5, i);
          //Adjusting the bus so it lands perfectly onto the dessert terrain
          Bus.transform.position = new Vector3(123, 2, i);
          Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
          //Changing the skybox to the stary dessert sky
          RenderSettings.skybox = Dessert_sky;
          //Moving the mountain terrain from behind the bus
          Mountain.transform.position = new Vector3(0, -1000, i);
          i = i + 235;
          //Getting the Lorry and car to land perfectly on the dessert plane
          Lorry.transform.position = new Vector3(132, 4, i-30);
          Lorry.transform.rotation = Quaternion.Euler(0, 180, 0);
          Car.transform.position = new Vector3(132, 4, i-100);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
          //Chaning the counter to print back to the mountain terrain
          counter = 1;
        }

        //If the counter is equal to 1
        else if(counter == 1)
        {
          //Changing the directional light back to make the scene brighter
          foreach(Light light in lights)
          {
            light.intensity = 1;
          }
          //Placing the mountain terrain directly after the dessert terrain
          Mountain.transform.position = new Vector3(0, 0, i);
          //Adjusting the bus so it lands perfectly onto the mountain terrain
          Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
          Bus.transform.position = new Vector3(126, 3, i);
          //Changing the skybox to the bright mountain sky
          RenderSettings.skybox = Mountain_sky;
          //Moving the dessert from behind the user
          Dessert.transform.position = new Vector3(0, -1000, i);
          i = i + 235;
          //Getting the Car and the lorry to land perfectly on the mountain terrain
          Car.transform.position = new Vector3(135, 2, i-100);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
          Lorry.transform.position = new Vector3(135, 2, i-30);
          Lorry.transform.rotation = Quaternion.Euler(0, 180, 0);
          counter = 0;
        }
      }

      //If the counter is 1
      if(counter == 1)
      {
        //If statements used to change the position of the lorry and Car from the end of the road to the start
        if(Lorry.transform.position.y < 3.4)
        {
          Lorry.transform.position = new Vector3(132, 4, i);
          Lorry.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if(Car.transform.position.y < 1.4)
        {
          Car.transform.position = new Vector3(132, 2, i);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
      }

      //If the counter is 0
      if(counter == 0)
      {
        //If statements used to change the position of the lorry and Car from the end of the road to the start
        if(Car.transform.position.y < 1.82 || Car.transform.position.y > 4)
        {
          Car.transform.position = new Vector3(135, 2, i);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        if(Lorry.transform.position.y < 2.7 || Lorry.transform.position.y > 5)
        {
          Lorry.transform.position = new Vector3(135, 3, i);
          Lorry.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
      }

      /*if(Bus.transform.position.x < 0 || Bus.transform.position.x > 255)
      {
          Bus.transform.position = new Vector3(126, 3, i-235);
          Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
      }*/

      //IF the player presses "r"
      if(Input.GetKeyDown("r"))
      {
        //Putting the bus back at the start of the road
        Bus.transform.position = new Vector3(126, 3, i-235);
        Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
      }

    }

    IEnumerator ScoreBeaten()
    {
      //If else statements to change the high score color on the canvas to green and blue to alert they player they have beaten the high score every 1 second
      if(alertscorebeaten == 0)
      {
        High.color = Color.blue;
        yield return new WaitForSeconds(1);
        alertscorebeaten = 1;
      }
      else
      {
        High.color = Color.green;
        yield return new WaitForSeconds(1);
        alertscorebeaten = 0;
      }
    }
}
