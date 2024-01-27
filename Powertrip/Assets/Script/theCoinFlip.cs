using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theCoinFlip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<GameController>().whereAmI >= 3 && Input.GetKeyDown("3"))
        {
            GetComponent<GameController>().currentAbility = GetComponent<GameController>().theAbilities[2];
        }
    }
}
