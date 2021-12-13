using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip crash;
    public AudioClip horn;
    public AudioSource audio;
    public float scale = 0.7f;

    void update()
    {
      audio.Play();
    }

    /*void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.name == "Car")
      {
        audio.clip = crash;
      }
      if(collision.gameObject.name == "Lorry")
      {
        audio.clip = horn;
      }
    }*/
}
