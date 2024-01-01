using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text CounterText;
    [SerializeField] private int Count = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            Count -= 1;
        };
        CounterText.text = "Count : " + Count;
    
    }
}
