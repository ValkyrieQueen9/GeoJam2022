using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMove2 : MonoBehaviour
{
    private float xDrag;
    private float yDrag;
    private float zDrag;

    public float speed;

    private Collider2D col;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse button is held");
            //xDrag = Input.GetAxis("Mouse X");
           // yDrag = Input.GetAxis("Mouse Y");
            zDrag = Input.GetAxis("Mouse X");

            if (zDrag > 0)
            {
                Debug.Log("Z Axis Drag " + zDrag);
            }

            //if (yDrag > 0)
            //{
           //     Debug.Log("Y Axis Drag " + yDrag);
           // }

            //transform.Rotate(Vector2.left, xDrag, Space.World);
            //transform.Rotate(Vector2.down, yDrag, Space.World);
            transform.Rotate(Vector2.down, zDrag);
        }
        
    }
}
