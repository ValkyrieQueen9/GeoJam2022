using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeRotate : MonoBehaviour
{

    public float rotationSpeed = 1f;

void OnMouseDrag()
{
        float XaxisRotation = Input.GetAxisRaw("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxisRaw("Mouse Y") * rotationSpeed;
        float ZaxisRotation = Input.GetAxisRaw("Mouse Y") * rotationSpeed;

        //transform.Rotate(Vector2.down, XaxisRotation);
        //transform.Rotate(Vector2.right, YaxisRotation);

        transform.Rotate(Vector2.left, XaxisRotation, Space.World);
        transform.Rotate(Vector2.down, YaxisRotation, Space.World);
        transform.Rotate(Vector2.down, ZaxisRotation, Space.World);
    }

}

