using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraX : MonoBehaviour
{
    private float rotationSpeed = 10;
    public GameObject player;
    float yRotation = 0;

    // Update is called once per frame
    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");
        // your other, unrelated code
        yRotation += _mouseX * rotationSpeed;
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
        transform.position = player.transform.position; // Move focal point with player

    }
}
