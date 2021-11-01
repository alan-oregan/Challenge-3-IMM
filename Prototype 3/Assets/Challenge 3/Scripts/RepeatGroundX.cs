using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatGroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x ; // to the size of the ground
    }

    private void Update()
    {
        // If ground moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}


