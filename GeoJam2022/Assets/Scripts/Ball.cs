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
        //Change the launch method to start when a PLAY button is clicked later.
    {
        Launch();
        posx = this.gameObject.transform.position.x;
        posy = this.gameObject.transform.position.y;
    }

    private void Launch()
    {
        rb.velocity = new Vector2(posx, posy - speed);
    }

}
