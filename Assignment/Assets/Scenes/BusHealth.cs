using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusHealth : MonoBehaviour
{
    public Text text;
    public int health;
    public int alertcolourchange = 0;
    public bool cartriggered = false;
    public bool bustriggered = false;
    public bool cactustriggered = false;

    void Start()
    {
      health = 100;
    }

    void Update()
    {
      text.text = "Health: " + health;
      if(health <= 30)
      {
        StartCoroutine(Alert());
      }

      if(health <= 0)
      {
        Debug.Log("DEAD");
        Application.LoadLevel("SampleScene");
      }
    }

    IEnumerator Alert()
    {
      if(alertcolourchange == 0)
      {
        text.color = Color.red;
        yield return new WaitForSeconds(1);
        alertcolourchange = 1;
      }
      else
      {
        text.color = Color.white;
        yield return new WaitForSeconds(1);
        alertcolourchange = 0;
      }
    }


    void OnTriggerEnter(Collider collision)
    {
      if(collision.gameObject.name == "Car")
      {
        if(cartriggered == false)
        {
            cartriggered = true;
            StartCoroutine(Car());
        }
      }

      if(collision.gameObject.name == "Lorry")
      {
        if(bustriggered == false)
        {
            bustriggered = true;
            StartCoroutine(Lorry());
        }
      }
    }

    IEnumerator Car()
    {
        health = health - 10;
        yield return new WaitForSeconds(1);
        cartriggered = false;
    }

    IEnumerator Lorry()
    {
        health = health - 30;
        yield return new WaitForSeconds(1);
        bustriggered = false;
    }

}
