using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theCoinFlip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator coinFlipCooldown()
    {
        GetComponent<GameController>().theCoinFlipCooldown = true;
        yield return new WaitForSeconds(60);
        GetComponent<GameController>().theCoinFlipCooldown = false;
    }
}
