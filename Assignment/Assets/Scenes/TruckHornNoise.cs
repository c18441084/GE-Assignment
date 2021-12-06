using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckHornNoise : MonoBehaviour
{

  public AudioSource truckHorn;

  void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.name == "Lorry")
    {
      truckHorn.Play();
    }
  }
}
