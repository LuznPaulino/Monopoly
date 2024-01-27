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
        GameObject theBullet = Instantiate(GetComponent<GameController>().bulletTwo, GameObject.Find("bulletSpawn").transform);
        theBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
        yield return new WaitForSeconds(2);
        Destroy(theBullet);
    }
}
