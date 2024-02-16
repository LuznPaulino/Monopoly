using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBarrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EdgeCollider2D barrier = this.gameObject.AddComponent<EdgeCollider2D>();
        List<Vector2> theScreenBarrier = new List<Vector2>();
        GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector2(0, GameObject.Find("Main Camera").GetComponent<Camera>().pixelHeight));
        theScreenBarrier.Add(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector2(0, GameObject.Find("Main Camera").GetComponent<Camera>().pixelHeight)));
        theScreenBarrier.Add(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector2(GameObject.Find("Main Camera").GetComponent<Camera>().pixelWidth, GameObject.Find("Main Camera").GetComponent<Camera>().pixelHeight)));
        theScreenBarrier.Add(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector2(GameObject.Find("Main Camera").GetComponent<Camera>().pixelWidth, 0)));
        theScreenBarrier.Add(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector2(0, 0)));
        theScreenBarrier.Add(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector2(0, GameObject.Find("Main Camera").GetComponent<Camera>().pixelHeight)));
        barrier.SetPoints(theScreenBarrier);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
