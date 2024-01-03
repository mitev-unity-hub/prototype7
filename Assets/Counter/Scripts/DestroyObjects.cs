using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private float destroyYPosition = 0.25f;
    void Update()
    {
        if (gameObject.transform.position.y == destroyYPosition)
        {
            Destroy(gameObject);
        }
    }
}
