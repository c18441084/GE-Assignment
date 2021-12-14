using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorryHornSound : MonoBehaviour
{
    //Attribute used to source the truck horn clip from the AudioSource
    public AudioSource horn;

    //Function used to detect a collision
    void OnCollisionEnter(Collision col)
    {
      //If the lorry collides with the bus
      if(col.gameObject.name == "Bus")
      {
        //Playing the truck horn audio
        horn.Play();
      }
    }
}
