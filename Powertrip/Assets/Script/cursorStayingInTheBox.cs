using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorStayingInTheBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), GameObject.FindWithTag("Player").GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), GameObject.FindWithTag("Barrier").GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
