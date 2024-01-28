using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGotHitByBullets : MonoBehaviour
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
        if(collision.gameObject.tag == "Boss Ammo")
        {
            if (GetComponent<GameController>().theCoinFlipShield)
            {
                GetComponent<GameController>().playerHealthDeducted(0);
            }
            else
            {
                GetComponent<GameController>().playerHealthDeducted(10);
            }
        }
    }
}
