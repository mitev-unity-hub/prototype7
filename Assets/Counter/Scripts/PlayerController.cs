using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalConstrains = 1.4f;
    [SerializeField] private float speed = 2f;
    private Counter Counter;
   
    private void Start()
    {
        Counter = GameObject.Find("Bottom").GetComponent<Counter>();
    }
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
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        Vector3 movement = new Vector3 (horizontalInput, 0, 0) * speed * Time.deltaTime;
        transform.position += movement;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Sphere")) 
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            float randomDirection = Random.Range(-1, 1);
            rb.AddForce(new Vector3(randomDirection, 1, 0) * 10f, ForceMode.Impulse);
            if (Counter != null)
            {
                Counter.Count +=1;
                Counter.CounterText.text = "Count : " + 1;
            }
        }
    }
}
