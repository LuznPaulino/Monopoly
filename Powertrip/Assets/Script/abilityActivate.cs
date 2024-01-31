using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityActivate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            StartCoroutine("abilitiesNow");
        }
    }

    IEnumerator abilitiesNow()
    {
        if(GetComponent<abilitySwitch>().currentAbility == "Debt Collector" && (!GetComponent<GameController>().debtCollectorCooldown))
        {
            GetComponent<GameController>().debtCollectorLifeSteal = true;
            yield return new WaitForSeconds(20);
            GetComponent<GameController>().debtCollectorLifeSteal = false;
            StartCoroutine(GetComponent<debtCollector>().debtCollectorCooldown());
        }
        if (GetComponent<abilitySwitch>().currentAbility == "The Pocketbook" && (!GetComponent<GameController>().pocketbookCooldown))
        {
            GetComponent<GameController>().thePocketBookSlowYourRoll = true;
            yield return new WaitForSeconds(20);
            GetComponent<GameController>().thePocketBookSlowYourRoll = false;
            StartCoroutine(GetComponent<thePocketBook>().pocketbookCooldown());
        }
        if (GetComponent<abilitySwitch>().currentAbility == "The Coin Flip" && (!GetComponent<GameController>().theCoinFlipCooldown))
        {
            GetComponent<GameController>().theCoinFlipShield = true;
            yield return new WaitForSeconds(20);
            GetComponent<GameController>().theCoinFlipShield = false;
            StartCoroutine(GetComponent<theCoinFlip>().coinFlipCooldown());
        }
        yield return null;
    }
}
