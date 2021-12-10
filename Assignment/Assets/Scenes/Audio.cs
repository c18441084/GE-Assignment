using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip crash;
    public AudioClip horn;
    public AudioSource audio;
    public float scale = 0.7f;

    void Start()
    {
      audio.Play();
    }

    void onCollisionEnter(Collision collision)
    {
      Debug.Log("Entered");
      if(collision.gameObject.name == "Car")
      {
        audio.clip = crash;
        audio.Play();
      }
      if(collision.gameObject.tag == "Lorry")
      {
        audio.PlayOneShot(horn);
      }
    }
}
