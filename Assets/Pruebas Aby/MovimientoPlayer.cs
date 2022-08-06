using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public Vector3 desplazamiento;
    public float speed;
    public float vida;
    public int CristalDomo;
    public GameObject Domo;
    public GameObject Pad;
    public GameObject BaseC;
    public GameObject Cristales;
    public GameObject DomoUI;
   
    void Start()
    {
        
    }
    
    void Update()
    {
        Movimiento();
        
    }
    void Movimiento()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        float rot = Input.GetAxis("Mouse X");

       desplazamiento = new Vector3(hor, 0, ver);
       transform.Translate(desplazamiento * speed * Time.deltaTime);
       transform.Rotate(0, rot, 0);

    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.transform.tag == "Domo")
        {
            vida--;
        }      

        if (collision.collider.transform.tag == "BaseC")
        {
            var animCristal = Cristales.GetComponent<Animator>();
            animCristal.SetBool("Cristales", true);

            var animDomo = Domo.GetComponent<Animator>();
            animDomo.SetBool("Domo", true);

            Debug.Log("Recoge las municiones y destruye a los enemigos, puedes cambiar de arma con 1 y 2");
           

        }
        if(collision.collider.transform.tag == "Pad")
        {
            Debug.Log("Consigue los cristales y el arma para desactivar el Domo");
           
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.transform.name == "PressurePad")
        {
           DomoUI.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        DomoUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Cristales_Domo")
        {
            Destroy(other.transform.gameObject);
            CristalDomo ++;
            Debug.Log("Tienes: " + CristalDomo + " Cristales para desactivar el Domo");
        }

        if (CristalDomo >= 3)
        {
            Debug.Log("Dirigete a la base para colocar los cristales");
           
            var anim = BaseC.GetComponent<Animator>();
            anim.SetBool("BasesCristales",true);
            Destroy(Pad);
        }        
    }
}
