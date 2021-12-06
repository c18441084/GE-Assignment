using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
  public int counter = 0;
  public float i = 244;
  public AudioSource source;
  public Material Mountain_sky;
  public Material Dessert_sky;
    // Start is called before the first frame update
    void Start()
    {
      source.Play();
      RenderSettings.skybox = Mountain_sky;
    }

    // Update is called once per frame
    void Update()
    {
      if(GameObject.Find("Bus").transform.position.z>(i))
      {
        if(counter == 0){
          GameObject.Find("Dessert").transform.position = new Vector3(0, -5, i);
          RenderSettings.skybox = Dessert_sky;
          GameObject.Find("Mountain").transform.position = new Vector3(0, -1000, i);
          i = i + 244;
          GameObject.Find("Lorry").transform.position = new Vector3(132, 1, i-70);
          //GameObject.Find("Lorry").transform.rotation = Quaternion.Euler(0, 180, 0);
          counter = 1;
        }
        else if(counter == 1)
        {
          GameObject.Find("Mountain").transform.position = new Vector3(0, 0, i);
          RenderSettings.skybox = Mountain_sky;
          GameObject.Find("Dessert").transform.position = new Vector3(0, -1000, i);
          i = i + 244;
          GameObject.Find("Car").transform.position = new Vector3(136, 1, i-20);
          GameObject.Find("Car").transform.rotation = Quaternion.Euler(0, 180, 0);
          counter = 0;
        }
      }
    }
}
