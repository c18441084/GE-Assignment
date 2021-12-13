using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrainGen : MonoBehaviour
{
  //Attributes
  public Text showpoints;
  public int counter = 0;
  public int i = 235;
  public int points = 0;
  public PerlinNoise ground;
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
    }

    // Update is called once per frame
    void Update()
    {
      showpoints.text = "Portal Points: " + points;
      //IF statement to use when the bus goes past the 'i' limit of the 'z' axis
      if(Bus.transform.position.z>(i))
      {
        points++;
        //If counter equals zero it generates the mountain terrain
        if(counter == 0){
          foreach(Light light in lights)
          {
            light.intensity = 0;
          }
          Dessert.transform.position = new Vector3(0, -5, i);
          Bus.transform.position = new Vector3(123, 2, i);
          Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
          RenderSettings.skybox = Dessert_sky;
          Mountain.transform.position = new Vector3(0, -1000, i);
          i = i + 235;
          Lorry.transform.position = new Vector3(132, 4, i-30);
          Lorry.transform.rotation = Quaternion.Euler(0, 180, 0);
          Car.transform.position = new Vector3(132, 4, i-100);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
          counter = 1;
        }
        else if(counter == 1)
        {
          foreach(Light light in lights)
          {
            light.intensity = 1;
          }
          Mountain.transform.position = new Vector3(0, 0, i);
          Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
          Bus.transform.position = new Vector3(126, 3, i);
          RenderSettings.skybox = Mountain_sky;
          Dessert.transform.position = new Vector3(0, -1000, i);
          i = i + 235;
          Car.transform.position = new Vector3(135, 2, i-100);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
          Lorry.transform.position = new Vector3(135, 2, i-30);
          Lorry.transform.rotation = Quaternion.Euler(0, 180, 0);
          counter = 0;
        }
      }

      if(counter == 1)
      {
        if(Lorry.transform.position.y < 3.4)
        {
          Lorry.transform.position = new Vector3(132, 4, i);
          Lorry.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if(Car.transform.position.y < 1.7)
        {
          Car.transform.position = new Vector3(132, 2, i);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
      }

      if(counter == 0)
      {
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

      if(Bus.transform.position.x < 0 || Bus.transform.position.x > 255)
      {
          Bus.transform.position = new Vector3(126, 3, i-235);
          Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
      }

      if(Input.GetKeyDown("r"))
      {
        Bus.transform.position = new Vector3(126, 3, i-235);
        Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
      }

    }
}
