using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GunsRD : MensajesUI
{
 
    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject Crosshair;
    public float Bullet1Count = 5f;
    public float Bullet2Count = 3f;
    public float Damage = 1f;
    public Camera fpsCam;
    public float distance = 100;
    public ParticleSystem Flash1;
    public ParticleSystem Flash2;
    public AudioSource AudioHit;
    public AudioSource AudioShoot;
    public GameObject Image;
    public GameObject TDAObj;
    public int enemigos;
    public GameObject Key;




    void Start()
    {
        enemigos = 18;
    }

   
    void Update()
    {
       

        GunChange();
        Bullet1();
        Bullet2();        
    }

    void Bullet1()
    {
        if (Gun1.activeSelf == true && Input.GetButtonDown("Fire1"))
        {
            Bullet1Count = Bullet1Count - 1;
            if (Bullet1Count > 0)
            {
                Disparar();
                Flash1.Play();
                AudioShoot.Play();     
                
            }
            else
            {
                Bullet1Count = 0;
                Mensajes.text = "Reload!";
                Invoke("ResetearText", 2f);
            }
        }
    }
    void Bullet2()
    {
        if (Gun2.activeSelf == true && Input.GetButtonDown("Fire1"))
        {
            Bullet2Count = Bullet2Count - 1;
            if (Bullet2Count > 0)
            {
                Disparar();
                Flash2.Play();
                AudioShoot.Play();                
            }
            else
            {
                Bullet2Count = 0;
                Mensajes.text = "Reload!";
                Invoke("ResetearText", 2f);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Se obtine el arma 1
        if (collision.transform.tag == "Gun1")
        {
            GetGun1();
            Image.SetActive(true);
            Mensajes.text = "Para disparar presiona click";
            Invoke("ResetearText", 2f);
            var tdaswitch = TDAObj.GetComponent<TDA_Objetivos>();
            tdaswitch.Invoke("RecorrerLista", 1f);

        }
        //Se obtine el arma 2
        if (collision.transform.tag == "Gun2")
        {
            GetGun2();
            Mensajes.text = "Para disparar presiona click";
            Invoke("ResetearText", 2f);

        }
        //Se obtinen municiones para arma 1
        if (collision.transform.tag == "Bullets1")
        {
            Bullet1Count = Bullet1Count+10;
            
        }
        //Se obtinen municiones para arma 2
        if (collision.transform.tag == "Bullets2")
        {
            Bullet2Count = Bullet2Count + 5;

        }
        
    }
   void GetGun1()
    {
        Damage = 1;
        Gun1.SetActive(true);
        Gun2.SetActive(false);
        Crosshair.SetActive(true);

    }
    void GetGun2()
    {
        Damage = 1;
        Gun2.SetActive(true);
        Gun1.SetActive(false);
        Crosshair.SetActive(true);
    }

    private void Shoot()
    {
        
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, distance))
        {
            Debug.Log(hit.transform.name);
            EnemyHealth enemy = hit.transform.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(Damage);                               
                //AudioHit.Play();
            }            
        }        

    }
    void GunChange()
    {
        if (Gun2.activeSelf == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetGun1();
        }

        if (Gun1.activeSelf == true && Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetGun2();
        }
    }

    void Disparar()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "Enemy1")
            {
                Destroy(hit.transform.gameObject);
                enemigos--;
                if (enemigos == 0)
                {
                    DesactivarLlave();
                }
            }
        }
    }

    void DesactivarLlave()
    {        
            Key.SetActive(true);
            Mensajes.text = "¡Has desactivado la llave, recogela!";
            Invoke("ResetearText", 5f);        
    }




}
