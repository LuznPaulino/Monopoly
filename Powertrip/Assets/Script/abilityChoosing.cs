using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityChoosing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chooseOne(string choiceOne)
    {
        GameObject.FindWithTag("Player").GetComponent<abilitySwitch>().currentAbilities[1] = choiceOne;
        GameObject.Find("UpgradeScreen").SetActive(false);
    }
}
