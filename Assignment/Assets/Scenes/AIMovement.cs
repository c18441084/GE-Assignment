using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
  float moveSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
      if(col.gameObject.name == "Bus")
      {
        Debug.Log("Worked");
      }
    }
}
