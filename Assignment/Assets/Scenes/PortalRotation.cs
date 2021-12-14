using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Used to turn the portal image of a value of 30 every frae
        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
    }
}
