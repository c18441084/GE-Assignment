using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
  //Attributes
  public int counter = 0;
  public int i = 235;
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
      //IF statement to use when the bus goes past the 'i' limit of the 'z' axis
      if(Bus.transform.position.z>(i))
      {
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
          Car.transform.position = new Vector3(135, 2, i-20);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
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
      }
      if(counter == 0)
      {
        if(Car.transform.position.y < 1.82)
        {
          Car.transform.position = new Vector3(135, 2, i);
          Car.transform.rotation = Quaternion.Euler(0, 180, 0);
          //GameObject.Find("Car").rigidbody.velocity = 0;
        }
      }

      if(Bus.transform.position.x < 0 || Bus.transform.position.x > 255)
      {
          Bus.transform.position = new Vector3(126, 3, i-235);
          Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
      }

      if(Bus.transform.position.y < -1 || Bus.transform.position.y > 26)
      {
        Bus.transform.position = new Vector3(126, 3, i-235);
        Bus.transform.rotation = Quaternion.Euler(0, 0, 0);
      }

    }
}
