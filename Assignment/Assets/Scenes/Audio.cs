using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip crash;
    public AudioClip horn;
    public AudioSource audio;
    public float scale = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
      audio.Play();
    }

    void onCollosionEnter(Collision collision)
    {
      if(collision.gameObject.name == "Car")
      {
        audio.PlayOneShot(crash, scale);
      }
      if(collision.gameObject.tag == "Lorry")
      {
        audio.PlayOneShot(horn);
      }
    }
}
