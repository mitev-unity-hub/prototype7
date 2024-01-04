using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private float xRange = 1.4f;
    private float yRange = 8f;
    private float zRange = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = RandomSpawnPosition();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), yRange, zRange);
    }
}
