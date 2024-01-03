using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
     public int Count = 0;
    
    [SerializeField] public Text CounterText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            Count -= 1;
        };
        CounterText.text = "Count : " + Count;
        Destroy(other.gameObject); 
    }
}
