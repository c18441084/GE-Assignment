using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrashSound : MonoBehaviour
{
    public AudioSource crash;

    void OnCollisionEnter(Collision col)
    {
      if(col.gameObject.name == "Bus")
      {
        crash.Play();
      }
    }
}
