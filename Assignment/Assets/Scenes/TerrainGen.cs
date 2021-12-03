using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
  public int counter = 0;
  public float i = 256;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(GameObject.Find("Bus").transform.position.z>(244)){
        //GameObject.Find("Bus").transform.position = new Vector3(127, 37, 11);
        if(counter == 0){
          GameObject.Find("Dessert").transform.position = new Vector3(127, 19, 244);
          i = i + 244;
        }
      }
    }
}
