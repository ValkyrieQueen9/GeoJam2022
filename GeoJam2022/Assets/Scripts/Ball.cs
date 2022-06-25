using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float posx;
    private float posy;
    void Start()
    {
        Launch();
        posx = this.gameObject.transform.position.x;
        posy = this.gameObject.transform.position.y;
    }
    void Update()
    {
        
    }

    private void Launch()
    {
        rb.velocity = new Vector2(speed * posx, speed * posy -2);
    }

}
