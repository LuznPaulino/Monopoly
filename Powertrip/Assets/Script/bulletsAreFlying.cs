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
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePresent)
        {
            GameObject.Find("pointer").GetComponent<Transform>().position = new Vector3(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x, GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y, 0);
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine("bulletFlying");
            }
        }
        else
        {

        }
        //GameObject.Find("pointer").GetComponent<Transform>().position = new Vector3(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x, GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y,0);
    }


    IEnumerator bulletFlying()
    {
            if (GetComponent<weaponSwitch>().currentLoadOut == "shootone")
            {
                if (GetComponent<abilitySwitch>().currentAbility == "Debt Collector" && GetComponent<GameController>().debtCollectorLifeSteal)
                {
                    GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform.position, GameObject.Find("bulletSpawn").transform.rotation);
                    theBullet.tag = "lifeStealDebtCollector";
                    theBullet.GetComponent<Rigidbody2D>().velocity = 10 * (GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - GameObject.Find("bulletSpawn").transform.position).normalized;
                    yield return new WaitForSeconds(2);
                    Destroy(theBullet);
                }
                if (GetComponent<abilitySwitch>().currentAbility == "The Pocketbook" && GetComponent<GameController>().thePocketBookSlowYourRoll)
                {
                    GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform.position, GameObject.Find("bulletSpawn").transform.rotation);
                    theBullet.tag = "SlowRollPocketBook";
                    theBullet.GetComponent<Rigidbody2D>().velocity = 10 * (GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - GameObject.Find("bulletSpawn").transform.position).normalized;
                    yield return new WaitForSeconds(2);
                    Destroy(theBullet);
                }
                else
                {
                    GameObject theBullet = Instantiate(bullet, GameObject.Find("bulletSpawn").transform.position, GameObject.Find("bulletSpawn").transform.rotation);
                    theBullet.GetComponent<Rigidbody2D>().velocity = 10 * (GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - GameObject.Find("bulletSpawn").transform.position).normalized;
                    yield return new WaitForSeconds(2);
                    Destroy(theBullet);
                }
            }
            if (GetComponent<weaponSwitch>().currentLoadOut == "shoottwo")
            {
                if (GetComponent<abilitySwitch>().currentAbility == "Debt Collector" && GetComponent<GameController>().debtCollectorLifeSteal)
                {
                    GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform.position, GameObject.Find("bulletSpawn").transform.rotation);
                    theBullet.tag = "lifeStealDebtCollector";
                    theBullet.GetComponent<Rigidbody2D>().velocity = 10 * (GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - GameObject.Find("bulletSpawn").transform.position).normalized;
                    yield return new WaitForSeconds(2);
                    Destroy(theBullet);
                }
                if (GetComponent<abilitySwitch>().currentAbility == "The Pocketbook" && GetComponent<GameController>().thePocketBookSlowYourRoll)
                {
                    GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform.position, GameObject.Find("bulletSpawn").transform.rotation);
                    theBullet.tag = "SlowRollPocketBook";
                    theBullet.GetComponent<Rigidbody2D>().velocity = 10 * (GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - GameObject.Find("bulletSpawn").transform.position).normalized;
                    yield return new WaitForSeconds(2);
                    Destroy(theBullet);
                }
                else
                {
                    GameObject theBullet = Instantiate(bulletTwo, GameObject.Find("bulletSpawn").transform.position, GameObject.Find("bulletSpawn").transform.rotation);
                    theBullet.GetComponent<Rigidbody2D>().velocity = 10 * (GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - GameObject.Find("bulletSpawn").transform.position).normalized;
                    yield return new WaitForSeconds(2);
                    Destroy(theBullet);
                }
            }
            yield return null;
    }

}
