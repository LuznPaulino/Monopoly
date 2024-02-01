using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSwitch : MonoBehaviour
{
    string[] weaponChoices = { "shootone", "shoottwo" };
    int currentPlace = 0;
    public string currentLoadOut = "shootone";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y >= 1f)
        {  
            currentPlace++;
            if(currentPlace>=0 && currentPlace <= 6)
            {
                currentLoadOut = weaponChoices[0];
            }
            if(currentPlace > 6)
            {
                currentPlace = -7;
                currentLoadOut = weaponChoices[1];
            }
        }
        if (Input.mouseScrollDelta.y <= -1f)
        {
            currentPlace--;
            if (currentPlace >= -7 && currentPlace <= -1)
            {
                currentLoadOut = weaponChoices[1];
            }
            if (currentPlace < -7)
            {
                currentPlace = 6;
                currentLoadOut = weaponChoices[0];
            }
        }
    }
}
