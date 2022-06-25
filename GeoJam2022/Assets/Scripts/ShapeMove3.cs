using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMove3 : MonoBehaviour
{
    public float rotationSpeed = 45;

    private Camera myCam;
    private Vector3 screenPos;
    private float angleOffset;
    private Collider2D col;

    private bool isDragging;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        Vector3 mousePos = myCam.ScreenToWorldPoint(Input.mousePosition);

        if (isDragging)
            {
                screenPos = myCam.WorldToScreenPoint(transform.position);
                Vector3 vec3 = Input.mousePosition - screenPos;
                angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y, vec3.x)) * Mathf.Rad2Deg;
                float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, 0, angle + angleOffset);
            }
        }
    }

