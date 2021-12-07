using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip song;
    public AudioClip crash;
    public AudioClip horn;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(song);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void onCollosionEnter(Collision collision)
    {
      if(collision.gameObject.name == "Car")
      {
        audio.PlayOneShot(crash);
      }
      if(collision.gameObject.tag == "Lorry")
      {
        audio.PlayOneShot(horn);
      }
    }
}
