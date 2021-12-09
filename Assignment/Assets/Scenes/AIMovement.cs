using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
  float moveSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        //while(transform.position.y > 0)
        //{
          transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        //}
    }

}
