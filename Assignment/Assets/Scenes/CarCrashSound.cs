using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrashSound : MonoBehaviour
{
    //Attribute used to source the crash clip from the AudioSource
    public AudioSource crash;

    //Collision function used to detect a collision
    void OnCollisionEnter(Collision col)
    {
      //If the Car collides with the Bus
      if(col.gameObject.name == "Bus")
      {
        //Playing the car crash audio
        crash.Play();
      }
    }
}
