using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thePocketBook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<GameController>().whereAmI >= 2 && Input.GetKeyDown("2"))
        {
            GetComponent<GameController>().currentAbility = GetComponent<GameController>().theAbilities[1];
        }
    }

    public void maxiumDamage()
    {
        GameObject.FindWithTag("Boss").GetComponent<bossOne>().bossHealth -= 20;
    }

    IEnumerable pocketbookCooldown()
    {
        GetComponent<GameController>().pocketbookCooldown = true;
        yield return new WaitForSeconds(60);
        GetComponent<GameController>().pocketbookCooldown = false;
    }
}
