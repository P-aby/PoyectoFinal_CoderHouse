using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsRD : MonoBehaviour
{
    public GameObject BulletObject;
    public GameObject Gun1;
    public GameObject Gun2;
    public float Bullet1Count = 5f;
    public float Bullet2Count = 3f;
    public float Damage = 1f;
    public enum GunType
    {
        Gun1,
        Gun2,
    }

    public GunType guns;
    void Start()
    {
        
    }

   
    void Update()
    {
       
        switch (guns)
        {
            
            case GunType.Gun1:
                GunType1();               
                break;

            case GunType.Gun2:
                GunType2();                
                break;

        }
    }



    void GunType1()
    {
        Bullet1();
        Damage = 1;
        
    }
    void GunType2()
    {
        Bullet2();
        Damage = 3;
        
    }

    void Bullet1()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bullet1Count = Bullet1Count - 1;
            if (Bullet1Count > 0)
            {
                Instantiate(BulletObject);
                Debug.Log("FIRE");
            }
            else
            {
                Bullet1Count = 0;
                Debug.Log("Reload!!");
            }
        }
    }
    void Bullet2()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bullet2Count = Bullet2Count - 1;
            if (Bullet2Count > 0)
            {
                Instantiate(BulletObject);
                Debug.Log("FIRE");
            }
            else
            {
                Bullet2Count = 0;
                Debug.Log("Reload!!");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Gun1")
        {
            GetGun1();
            //aqui se deberían activar los objetos bullet que te dan balas (Bullet1), no se si instanciar o ponerlos activos
        }

        if (collision.transform.tag == "Gun2")
        {
            GetGun2();
            //aqui se bebería de desactivar la Gun1 y qudar la Gun2, también activar los objetos Bullet2 que dan balas a esta arma
        }

        if (collision.transform.tag == "Bullets1")
        {
            Bullet1Count = Bullet1Count+10;
            
        }
        if (collision.transform.tag == "Bullets2")
        {
            Bullet2Count = Bullet2Count + 5;

        }
        
    }
   void GetGun1()
    {
        //Gun1 = Instantiate(Gun1, transform.position, transform.rotation);
        // Gun1.transform.parent = GameObject.Find("PlayerRD").transform;

        //var player = transform;
        //player = (GameObject.Find("PlayerRD")).transform;
        //Instantiate(Gun1).transform.parent = player;
        Instantiate(Gun1, transform.position, Quaternion.identity, transform);


    }
    void GetGun2()
    {
        Instantiate(Gun2);
    }
}
