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
        currentLoadOut = weaponChoices[currentPlace];
        if (Input.mouseScrollDelta.y >= 1f)
        {
            currentPlace++;
            if (currentPlace >= 2)
            {
                currentPlace = 0;
            }
        }
        if (Input.mouseScrollDelta.y <= -1f)
        {
            currentPlace--;
            if (currentPlace <= -1)
            {
                currentPlace = 1;
            }
        }
    }
}
