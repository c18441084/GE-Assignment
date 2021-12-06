﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

    [Range(0, 360)]
    public float rotationSpeed = 180f;
    public float moveSpeed = 20.0f;
    public AudioSource crash;

    void Start ()
    {
      crash = GameObject.FindObjectOfType<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.name == "Car")
      {
        crash.Play();
      }
    }

  	// Update is called once per frame
  	void Update () {
          if (Input.GetKey(KeyCode.Escape))
          {
              Application.Quit();
          }
          transform.Translate(0, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
          transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);

      }
}
