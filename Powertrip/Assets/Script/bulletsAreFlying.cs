using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsAreFlying : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletTwo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("bulletFlying");
        }



    }

    IEnumerator bulletFlying()
    {
        if(GetComponent<weaponSwitch>().currentLoadOut == "shootone")
        {
            if (GetComponent<abilitySwitch>().currentAbility == "Debt Collector" && GetComponent<GameController>().debtCollectorLifeSteal)
            {
                GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform);
                theBullet.tag = "lifeStealDebtCollector";
                theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10;
                yield return new WaitForSeconds(2);
                Destroy(theBullet);
            }
            if (GetComponent<abilitySwitch>().currentAbility == "The Pocketbook" && GetComponent<GameController>().thePocketBookSlowYourRoll)
            {
                GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform);
                theBullet.tag = "SlowRollPocketBook";
                theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 1;
                yield return new WaitForSeconds(2);
                Destroy(theBullet);
            }
            else
            {
                GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform);
                theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10;
                yield return new WaitForSeconds(2);
                Destroy(theBullet);
            }
        }
        if (GetComponent<weaponSwitch>().currentLoadOut == "shoottwo")
        {
            if (GetComponent<abilitySwitch>().currentAbility == "Debt Collector" && GetComponent<GameController>().debtCollectorLifeSteal)
            {
                GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform);
                theBullet.tag = "lifeStealDebtCollector";
                theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
                yield return new WaitForSeconds(2);
                Destroy(theBullet);
            }
            if (GetComponent<abilitySwitch>().currentAbility == "The Pocketbook" && GetComponent<GameController>().thePocketBookSlowYourRoll)
            {
                GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform);
                theBullet.tag = "SlowRollPocketBook";
                theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 1;
                yield return new WaitForSeconds(2);
                Destroy(theBullet);
            }
            else
            {
                GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform);
                theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
                yield return new WaitForSeconds(2);
                Destroy(theBullet);
            }
        }
        yield return null;
    }

    /*
    if (GetComponent<GameController>().currentAbility.Equals("Debt Collector") && (!GetComponent<GameController>().debtCollectorCooldown))
        {
            GetComponent<GameController>().theCoinFlipShield = true;
            yield return new WaitForSeconds(10);
            GetComponent<GameController>().theCoinFlipShield = false;
            StartCoroutine("GetComponent<theCoinFlip>().coinFlipCooldown");


            GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform);
            theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10;
            yield return new WaitForSeconds(2);
            Destroy(theBullet);
            StartCoroutine("GetComponent<debtCollector>().debtCollectorCooldown");
        }

        if (GetComponent<GameController>().currentAbility.Equals("The Pocketbook") && (!GetComponent<GameController>().pocketbookCooldown))
        {
            GetComponent<GameController>().theCoinFlipShield = true;
            yield return new WaitForSeconds(10);
            GetComponent<GameController>().theCoinFlipShield = false;
            StartCoroutine("GetComponent<theCoinFlip>().pocketbookCooldown");

            GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform);
            theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
            yield return new WaitForSeconds(2);
            Destroy(theBullet);
            StartCoroutine("GetComponent<thePocketBook>().pocketbookCooldown()");
        }


        if (GetComponent<GameController>().currentAbility.Equals("The Coin Flip") && (!GetComponent<GameController>().theCoinFlipCooldown))
        {
            GetComponent<GameController>().theCoinFlipShield = true;
            yield return new WaitForSeconds(10);
            GetComponent<GameController>().theCoinFlipShield = false;
            StartCoroutine("GetComponent<theCoinFlip>().coinFlipCooldown");
        }
     */
}
