using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsAreFlying : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletTwo;
    public GameObject bulletThree;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine("bulletFlying");
        }

    }

    IEnumerable bulletFlying()
    {
        if (GetComponent<GameController>().currentAbility.Equals("Debt Collector") && (!GetComponent<GameController>().debtCollectorCooldown))
        {
            GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform);
            theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10;
            yield return new WaitForSeconds(2);
            Destroy(theBullet);
            StartCoroutine("GetComponent<debtCollector>().debtCollectorCooldown");
        }

        if (GetComponent<GameController>().currentAbility.Equals("The Pocketbook") && (!GetComponent<GameController>().pocketbookCooldown))
        {
            GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform);
            theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
            yield return new WaitForSeconds(2);
            Destroy(theBullet);
            StartCoroutine("GetComponent<thePocketBook>().pocketbookCooldown()");
        }


        if (GetComponent<GameController>().currentAbility.Equals("The Coin Flip") && (!GetComponent<GameController>().theCoinFlipCooldown))
        {
            GetComponent<GameController>().theCointFlipShield = true;
            yield return new WaitForSeconds(10);
            GetComponent<GameController>().theCointFlipShield = false;
            StartCoroutine("GetComponent<theCoinFlip>().coinFlipCooldown");
        }
    }
}
