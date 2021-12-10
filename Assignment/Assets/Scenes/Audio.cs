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

    void onTriggerEnter(Collider collision)
    {
      if(collision.gameObject.name == "Car")
      {
        Debug.Log("Entered");
        audio.clip = crash;
        audio.Play();
      }
      if(collision.gameObject.tag == "Lorry")
      {
        audio.PlayOneShot(horn);
      }
    }
}
