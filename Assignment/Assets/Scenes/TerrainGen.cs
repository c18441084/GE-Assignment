using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
  public int counter = 0;
  public float i = 244;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(GameObject.Find("Bus").transform.position.z>(i)){
        //GameObject.Find("Bus").transform.position = new Vector3(127, 37, 11);
        if(counter == 0){
          GameObject.Find("Dessert").transform.position = new Vector3(0, 18, i);
          i = i + 244;
          counter = 1;
        }
        else if(counter == 1){
          GameObject.Find("Mountain Range").transform.position = new Vector3(0, 0, i);
          i = i + 244;
          counter = 0;
        }
      }
    }
}
