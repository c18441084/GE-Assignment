using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource crash;
    public AudioSource horn;
    public AudioSource audio;
    public float scale = 0.7f;

    void update()
    {
      audio.Play();
    }

    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.name == "Car")
      {
        crash.Play();
      }
      if(collision.gameObject.name == "Lorry")
      {
        horn.Play();
      }
    }
}
