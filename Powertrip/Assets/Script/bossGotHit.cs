using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossGotHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "lifeStealDebtCollector")
        {
            GameObject.FindWithTag("Player").GetComponent<debtCollector>().recieveHealthBack();
        }
        if (collision.gameObject.tag == "SlowRollPocketBook")
        {
            GameObject.FindWithTag("Player").GetComponent<thePocketBook>().maxiumDamage();
        }
        if (collision.gameObject.tag == "Ammo")
        {
            GameObject.FindWithTag("Boss").GetComponent<bossOne>().bossHealthDecrease(1);
        }
    }
}
