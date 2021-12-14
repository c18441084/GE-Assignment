using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusController : MonoBehaviour {

    //Attributes
    public float rotationSpeed = 180f;
    //How fast the Bus will move
    public int moveSpeed = 20;
    //AudioSource used to play the background music
    public AudioSource audio;

    void Start()
    {
      //Starting the background music
      audio.Play();
    }
  	// Update is called once per frame
  	void Update ()
    {
        //Allowing the user to move the bus
        transform.Translate(0, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
    }
}
