using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    //create necessary member variable
    public Text zenText;
    public bool isZen;

    void Start()
    {
        //initialize isZen to false
        this.isZen = false;
    }
    void Update()
    {
        //if isZen is true this means the user has completed their task, so the UI tells them that information
        if(this.isZen == true)
        {
            zenText.text = "You are a zen master!";
        }
    }
}
