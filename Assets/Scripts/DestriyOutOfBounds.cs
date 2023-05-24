using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestriyOutOfBounds : MonoBehaviour
{

    private float topBound = -12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < topBound)
        {
            Destroy(gameObject);
        }
    }
}
