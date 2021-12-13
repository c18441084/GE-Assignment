using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorryHornSound : MonoBehaviour
{
    public AudioSource horn;

    void OnCollisionEnter(Collision col)
    {
      if(col.gameObject.name == "Bus")
      {
        horn.Play();
      }
    }
}
