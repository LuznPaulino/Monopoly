using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossOne : MonoBehaviour
{
    public int bossHealth = 100;

    public int bossDirection = 1;
    public GameObject bossBullet;
    public float currentAngle = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bossFightStages());
    }

    // Update is called once per frame
    void Update()
    {
        if (bossHealth <= 6 && bossHealth > 3)
        {
            GameObject.Find("centerOfChamber").GetComponent<Transform>().LookAt(GameObject.Find("playerCenter").GetComponent<Transform>().position);
            Vector3 theZFactor = GameObject.Find("centerOfChamber").GetComponent<Transform>().rotation.eulerAngles;
            if (theZFactor.y == 270)
            {
                GameObject.Find("theBossBarrell").GetComponent<Transform>().rotation = Quaternion.Euler(0f, 0f, theZFactor.x);
            }
            if (theZFactor.y == 90)
            {
                GameObject.Find("theBossBarrell").GetComponent<Transform>().rotation = Quaternion.Euler(0f, 0f, 180 - theZFactor.x);
            }
        }
    }

    IEnumerator bossFightStages()
    {
        while (bossHealth >= 0)
        {
            if (bossHealth <= 9 && bossHealth > 6)
            {
                if (bossDirection == 1)
                {
                    this.GetComponent<Transform>().Translate(Vector2.left * 0.01f);
                }
                if (bossDirection == 2)
                {
                    this.GetComponent<Transform>().Translate(Vector2.right * 0.01f);
                }
            }
            else if (bossHealth <= 6 && bossHealth > 3)
            {
                this.GetComponent<Transform>().Translate(Vector2.zero);
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                this.GetComponent<Rigidbody2D>().gravityScale = 0;
                this.GetComponent<Rigidbody2D>().isKinematic = true;
                yield return new WaitForSeconds(1);
                int randomPlace = Random.Range(0, 3);
                switch (randomPlace)
                {
                    case 0:
                        this.GetComponent<Transform>().position = GameObject.Find("top").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                    case 1:
                        this.GetComponent<Transform>().position = GameObject.Find("bottomLeft").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                    case 2:
                        this.GetComponent<Transform>().position = GameObject.Find("bottomRight").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                    default:
                        this.GetComponent<Transform>().position = GameObject.Find("top").GetComponent<Transform>().position;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                        StartCoroutine(bulletsFlyingOff());
                        yield return new WaitForSeconds(2);
                        break;
                }
            }
            else if (bossHealth <= 3 && bossHealth > 0)
            {
                if (bossDirection == 1)
                {
                    this.GetComponent<Transform>().Translate(Vector2.left * 0.01f);
                }
                if (bossDirection == 2)
                {
                    this.GetComponent<Transform>().Translate(Vector2.right * 0.01f);
                }
                StartCoroutine(randomBulletTime());
            }
            else
            {
                Destroy(this.gameObject);
            }

            yield return null; ;
        }
        yield return new WaitForSeconds(2);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "leftSide")
        {
            bossDirection = 2;
        }
        if (collision.name == "rightSide")
        {
            bossDirection = 1;
        }
    }

    public void bossHealthDecrease(int amount)
    {
        bossHealth-= amount;
    }

    IEnumerator bulletsFlyingOff()
    {
        GameObject theBullet = Instantiate(bossBullet, GameObject.Find("forwardBullet").transform.position, GameObject.Find("forwardBullet").transform.rotation);
        theBullet.GetComponent<Rigidbody2D>().velocity = 10f * ((GameObject.Find("playerCenter").GetComponent<Transform>().position - GameObject.Find("forwardBullet").transform.position).normalized);
        yield return new WaitForSeconds(2);
        Destroy(theBullet);
        yield return null;
    }

    IEnumerator randomBulletTime()
    {
        if (GameObject.FindGameObjectsWithTag("BossBullet").Length <= 6)
        {
            int randomGun = Random.Range(0, 3);
            switch (randomGun)
            {
                case 0:
                    GameObject theBullet = Instantiate(bossBullet, GameObject.Find("topLeft").transform.position, Quaternion.Euler(0, 0, 90));
                    theBullet.GetComponent<Rigidbody2D>().velocity = 10f * Vector2.down;
                    yield return new WaitForSeconds(2);
                    Destroy(theBullet);
                    yield return null;
                    break;
                case 1:
                    GameObject theBulletTwo = Instantiate(bossBullet, GameObject.Find("topMiddle").transform.position, Quaternion.Euler(0, 0, 90));
                    theBulletTwo.GetComponent<Rigidbody2D>().velocity = 10f * Vector2.down;
                    yield return new WaitForSeconds(2);
                    Destroy(theBulletTwo);
                    yield return null;
                    break;
                case 2:
                    GameObject theBulletThree = Instantiate(bossBullet, GameObject.Find("topRight").transform.position, Quaternion.Euler(0, 0, 90));
                    theBulletThree.GetComponent<Rigidbody2D>().velocity = 10f * Vector2.down;
                    yield return new WaitForSeconds(2);
                    Destroy(theBulletThree);
                    break;
                default:
                    GameObject theBulletFour = Instantiate(bossBullet, GameObject.Find("topMiddle").transform.position, Quaternion.Euler(0, 0, 90));
                    theBulletFour.GetComponent<Rigidbody2D>().velocity = 10f * Vector2.down;
                    yield return new WaitForSeconds(2);
                    Destroy(theBulletFour);
                    break;
            }
        }

    }


}
