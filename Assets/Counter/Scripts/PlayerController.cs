using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalConstrains = 1.4f;
    [SerializeField] private float speed = 2f;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -horizontalConstrains)
        {
            transform.position = new Vector3(-horizontalConstrains, transform.position.y, transform.position.z);
        }

        if (transform.position.x > horizontalConstrains)
        {
            transform.position = new Vector3(horizontalConstrains, transform.position.y, transform.position.z);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }
}
