using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
  //Setting the speed at which the car and lorry will move
  float moveSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
      //Getting the car and lorry to move
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
}
