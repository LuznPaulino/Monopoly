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
        
    }

    public void maxiumDamage()
    {
        GameObject.FindWithTag("Boss").GetComponent<bossOne>().bossHealthDecrease(20);
    }

    public IEnumerator pocketbookCooldown()
    {
        GetComponent<GameController>().pocketbookCooldown = true;
        yield return new WaitForSeconds(60);
        GetComponent<GameController>().pocketbookCooldown = false;
    }
}
