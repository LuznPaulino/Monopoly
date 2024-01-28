using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debtCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<GameController>().whereAmI >= 1 && Input.GetKeyDown("1"))
        {
            GetComponent<GameController>().currentAbility = GetComponent<GameController>().theAbilities[0];
        }
    }

    public void recieveHealthBack()
    {
        GetComponent<GameController>().playerHealth++;
    }

    IEnumerable debtCollectorCooldown()
    {
        GetComponent<GameController>().debtCollectorCooldown = true;
        yield return new WaitForSeconds(60);
        GetComponent<GameController>().debtCollectorCooldown = false;
    }
}
