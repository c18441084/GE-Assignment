using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusHealth : MonoBehaviour
{
  //Attributes
    public Text text;
    public int health;
    public int alertcolourchange = 0;
    public bool cartriggered = false;
    public bool bustriggered = false;
    public bool cactustriggered = false;

    //Function will start at the first frame
    void Start()
    {
      //Giving the player 100 health on the bus
      health = 100;
    }

    //Function will Repeat every frame of the game
    void Update()
    {
      //Adding player's health to canvas text
      text.text = "Health: " + health;

      //If the player's health is equal to or less than 30
      if(health <= 30)
      {
        //Start coroutine function
        StartCoroutine(Alert());
      }

      //If the player runs out of health it restarts the application
      if(health <= 0)
      {
        Application.LoadLevel("SampleScene");
      }
    }

    //coroutine function
    IEnumerator Alert()
    {
      //If else statements to change the health text color on the canvas to red and white to alert they player they are low on health every 1 second
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

    //A trigger function to reduce health on the bus
    void OnTriggerEnter(Collider collision)
    {
      //If the bus hits the car
      if(collision.gameObject.name == "Car")
      {
        //If the cartriggered is false it enters the statement
        //This true and false method is used to keep the bus constantly reducing health when it triggers with on object
        if(cartriggered == false)
        {
            //Setting cartriggered to true so that it doesn't enter the statement again
            cartriggered = true;
            //Calling the coroutine function
            StartCoroutine(Car());
        }
      }

      //If the bus hits the lorry
      if(collision.gameObject.name == "Lorry")
      {
        //If the bustriggered is false it enters the statement
        if(bustriggered == false)
        {
            //Setting bustriggered to true so that it doesn't enter the statement again
            bustriggered = true;
            //Calling coroutine function
            StartCoroutine(Lorry());
        }
      }
    }

    //coroutine function for car
    IEnumerator Car()
    {
        //taking a value of 10 off the player's health
        health = health - 10;
        //Waiting 1 second before setting the cartriggered back to false
        yield return new WaitForSeconds(1);
        cartriggered = false;
    }

    IEnumerator Lorry()
    {
        //taking a value of 30 off the player's health
        health = health - 30;
        //Waiting 1 second before setting the bustriggered back to false
        yield return new WaitForSeconds(1);
        bustriggered = false;
    }

}
