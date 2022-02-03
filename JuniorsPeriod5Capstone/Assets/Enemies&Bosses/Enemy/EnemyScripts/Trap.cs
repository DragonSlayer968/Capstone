﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float xKnock, yKnock;
    public Transform teleportPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<FillerHealth>().Hit();
            other.transform.position = new Vector3(teleportPoint.position.x, teleportPoint.position.y, teleportPoint.position.z);
           
        }
    }
}