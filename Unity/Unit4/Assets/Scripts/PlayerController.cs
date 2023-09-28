using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody PlayerRb;
    public bool hasPowerUp;
    public float speed = 2.0f;
    private GameObject focalPoint;
    private float powerUpStrength = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        PlayerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
        PlayerRb.AddForce(focalPoint.transform.right * horizontalInput * speed);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hasPowerUp && collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayfromplayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log("Collided with " + collision.gameObject.name + " powerup: " + hasPowerUp);
            enemyRb.AddForce(awayfromplayer * powerUpStrength, ForceMode.Impulse);
        } 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
        }
    }
}
