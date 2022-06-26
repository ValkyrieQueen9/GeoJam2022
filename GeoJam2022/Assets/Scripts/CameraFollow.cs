
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.125f;
    public float offset;

    private void LateUpdate()
    {
        float desiredPositio = target.position.x + offset;
        Vector3 desiredPosition = new Vector3(target.position.x, 0, offset);
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); //Supposed to smooth cam but makes mine worse - ignore
        transform.position = desiredPosition;
    }
}
