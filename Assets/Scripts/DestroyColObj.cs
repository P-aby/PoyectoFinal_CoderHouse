﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyColObj : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);

        }
    }

  
       
    }