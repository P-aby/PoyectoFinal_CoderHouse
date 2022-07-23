using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoB : MonoBehaviour
{
    public int vida;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.transform.tag == "Bala")
        {
            Destroy(collision.collider.gameObject);
            vida = vida - 1;
        }

        if (vida == 0)
        {
            Destroy(gameObject);
        }
    }
}
