using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour
{
    // Update is called once per frame
    GameObject gameManager;

    void Start()
    {
        //get the GameManager Object
        gameManager = GameObject.Find("GameManager");
    }
    void Update()
    {
        //if this rock is placed on the main pedastal we return a true to the isZen boolean, this will run for all rocks
        if ((this.transform.position.z >= 0.1 && this.transform.position.z <= 0.2) && (this.transform.position.x >0.4 && this.transform.position.x < 0.5))
        {
            gameManager.GetComponent<GameBehavior>().isZen = true;
        }
        //if not we set isZen to false
        else
        {
            gameManager.GetComponent<GameBehavior>().isZen = false;
        }
    }
}
