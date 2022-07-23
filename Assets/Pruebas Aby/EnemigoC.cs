using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoC : MonoBehaviour
{    
    void Start()
    {
        
    }
   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.tag == "Bala")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
        
    }
}
