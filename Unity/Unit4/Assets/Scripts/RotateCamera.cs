using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool cameraInputLeft = Input.GetKey("q");
        bool cameraInputRight = Input.GetKey("e");
        if (cameraInputLeft)
        {
            transform.Rotate(Vector3.up, 1 * rotationSpeed * Time.deltaTime);
        }
        if (cameraInputRight)
        {
            transform.Rotate(Vector3.up, -1 * rotationSpeed * Time.deltaTime);
        }
    }
}
