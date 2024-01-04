using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private ParticleSystem destroyParticles;

    private Text CounterText;
    private GameManager gameManager;
    private void Start()
    {
        CounterText = GameObject.Find("Text").GetComponent<Text>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bottom") && gameManager.isGameRunning)
        {
            gameManager.DecreaseCount();
        }

        CounterText.text = "Count : " + gameManager.count;
        Destroy(gameObject);
        Instantiate(destroyParticles, transform.position, destroyParticles.transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameManager.isGameRunning)
        {
            gameManager.IncreaseCount();
        }
        CounterText.text = "Count : " + gameManager.count;
    }
}
