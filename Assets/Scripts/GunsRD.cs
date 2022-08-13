using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunsRD : MonoBehaviour
{
 
    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject Crosshair;
    public float Bullet1Count = 5f;
    public float Bullet2Count = 3f;
    public float Damage = 1f;
    public Camera fpsCam;
    public float distance = 50;
    public ParticleSystem Flash1;
    public ParticleSystem Flash2;
    public AudioSource AudioHit;
    public AudioSource AudioShoot;
    public Text Mensajes;
    public GameObject Image;
    
    


    void Start()
    {
        
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
            //FindObjectOfType<MovimientoPlayer>().Disparo();
            if (Bullet1Count > 0)
            {
                Shoot();
                Flash1.Play();
                AudioShoot.Play();
                Debug.Log("FIRE");
                

            }
            else
            {
                Bullet1Count = 0;
                Debug.Log("Reload!!");
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
          // FindObjectOfType<MovimientoPlayer>().Disparo();
            if (Bullet2Count > 0)
            {
               
                Shoot();
                Flash2.Play();
                AudioShoot.Play();
                Debug.Log("FIRE");
            }
            else
            {
                Bullet2Count = 0;
                Debug.Log("Reload!!");
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

        }
        //Se obtine el arma 2
        if (collision.transform.tag == "Gun2")
        {
            GetGun2();
           
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
        Damage = 3;
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
                AudioHit.Play();
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
    public void ResetearText()
    {
        Mensajes.text = "";
    }

}
