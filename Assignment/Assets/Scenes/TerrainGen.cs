using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
  public int counter = 0;
  public int i = 235;
  public Material Mountain_sky;
  public Material Dessert_sky;
  private Light[] lights;
    // Start is called before the first frame update
    void Start()
    {
      RenderSettings.skybox = Mountain_sky;
      lights = FindObjectsOfType(typeof(Light)) as Light[];
    }

    // Update is called once per frame
    void Update()
    {
      if(GameObject.Find("Bus").transform.position.z>(i))
      {
        if(counter == 0){
          foreach(Light light in lights)
          {
            light.intensity = 0;
          }
          GameObject.Find("Dessert").transform.position = new Vector3(0, -5, i);
          GameObject.Find("Bus").transform.position = new Vector3(123, 2, i);
          GameObject.Find("Bus").transform.rotation = Quaternion.Euler(0, 0, 0);
          RenderSettings.skybox = Dessert_sky;
          GameObject.Find("Mountain").transform.position = new Vector3(0, -1000, i);
          i = i + 235;
          GameObject.Find("Lorry").transform.position = new Vector3(132, 4, i-30);
          GameObject.Find("Lorry").transform.rotation = Quaternion.Euler(0, 180, 0);
          counter = 1;
        }
        else if(counter == 1)
        {
          foreach(Light light in lights)
          {
            light.intensity = 1;
          }
          GameObject.Find("Mountain").transform.position = new Vector3(0, 0, i);
          GameObject.Find("Bus").transform.rotation = Quaternion.Euler(0, 0, 0);
          GameObject.Find("Bus").transform.position = new Vector3(126, 3, i);
          RenderSettings.skybox = Mountain_sky;
          GameObject.Find("Dessert").transform.position = new Vector3(0, -1000, i);
          i = i + 235;
          GameObject.Find("Car").transform.position = new Vector3(135, 2, i-20);
          GameObject.Find("Car").transform.rotation = Quaternion.Euler(0, 180, 0);
          counter = 0;
        }
      }
      if(counter == 1)
      {
        if(GameObject.Find("Lorry").transform.position.y < 3.4)
        {
          GameObject.Find("Lorry").transform.position = new Vector3(132, 4, i);
          GameObject.Find("Lorry").transform.rotation = Quaternion.Euler(0, 180, 0);
        }
      }
      if(counter == 0)
      {
        if(GameObject.Find("Car").transform.position.y < 1.82)
        {
          GameObject.Find("Car").transform.position = new Vector3(135, 2, i);
          GameObject.Find("Car").transform.rotation = Quaternion.Euler(0, 180, 0);
        }
      }

      if(GameObject.Find("Bus").transform.position.x < 0 || GameObject.Find("Bus").transform.position.x > 255)
      {
          GameObject.Find("Bus").transform.position = new Vector3(126, 3, i-235);
          GameObject.Find("Bus").transform.rotation = Quaternion.Euler(0, 0, 0);
      }
    }
}
