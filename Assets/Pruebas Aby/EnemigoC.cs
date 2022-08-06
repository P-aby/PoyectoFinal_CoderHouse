using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoC : MonoBehaviour
{
    public GameObject player;
    public Transform TransPlayer;
    public float speed;
    public int Tiempo_Enem;
    public Animator animEnemC;
   

    void Start()
    {
        
    }
   
    void Update()
    {
        Distanciaenemigo();
    }

    void SeguirPlayer()
    {
        
        transform.LookAt(TransPlayer);
        transform.position = Vector3.MoveTowards(transform.position, TransPlayer.position, speed * Time.deltaTime);
        
    }
    void AnimacionesEnemigo()
    {
        animEnemC.SetBool("Run Forward", true);
    }

    void Distanciaenemigo()
    {
        float dist = Vector3.Distance(transform.position, TransPlayer.position);

        if (dist < Tiempo_Enem)
        {
            SeguirPlayer();
            AnimacionesEnemigo();
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            FindObjectOfType<PlayerInterfaz>().RecibirGolpe();
        }
    }


}
