﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDA_Queue : MonoBehaviour
{
    Queue<GameObject> enemigos;
    public GameObject enemigo1;
    public GameObject enemigo2;
    public int quantity = 2;

    void Start()
    {
        enemigos.Enqueue(enemigo1);
        enemigos.Enqueue(enemigo2);
            
    }

    //private void OnCollisionEnter(Collision collision)
    //{
      //  if (collision.collider.transform.tag == "Player")
       // {
      //      enemigos.Dequeue();
     //   }
    //    Debug.Log("enemigos");
  //  }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.transform.tag == "Player")
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {

        Instantiate(enemigos.Dequeue());//, new Vector3(Random.Range(-100, 100), 0, Random.Range(-50, 100)), Quaternion.identity);
        //foreach(GameObject enemigos in ene)
        // {
        //    Debug.Log("enemigospawn");
        //     enemigos.Enqueue(Instantiate(enemigo2, new Vector3(Random.Range(-100, 100), 0, Random.Range(-50, 100)), Quaternion.identity));
        //  }

        // for (int i = 0; i < quantity; i++)
        // {
        //     Debug.Log(i);
        //     enemigos.Enqueue(Instantiate(enemigo2, new Vector3(Random.Range(-100, 100), 0, Random.Range(-50, 100)), Quaternion.identity));
        // }

    }
}
