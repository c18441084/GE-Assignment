using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusController : MonoBehaviour {

    [Range(0, 360)]
    public float rotationSpeed = 180f;
    public float moveSpeed = 20.0f;

    void Start()
    {
      Application.targetFrameRate = 20;
    }
  	// Update is called once per frame
  	void Update ()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
    }
}
