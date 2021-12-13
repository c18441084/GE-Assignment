using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusHealth : MonoBehaviour
{
    public Text text;
    public int health;
    public bool cartriggered = false;
    public bool bustriggered = false;

    void Start()
    {
      health = 100;
    }

    void Update()
    {
      text.text = "Health: " + health;
    }


    void OnTriggerEnter(Collider collision)
    {
      if(collision.gameObject.name == "Car")
      {
        if (cartriggered == false)
        {
            cartriggered = true;
            StartCoroutine(Car());
        }
      }

      if(collision.gameObject.name == "Lorry")
      {
        if (bustriggered == false)
        {
            bustriggered = true;
            StartCoroutine(Lorry());
        }
      }
    }

    IEnumerator Car()
    {
        health = health - 20;
        yield return new WaitForSeconds(1);
        cartriggered = false;
    }

    IEnumerator Lorry()
    {
        health = health - 40;
        yield return new WaitForSeconds(1);
        bustriggered = false;
    }
}
