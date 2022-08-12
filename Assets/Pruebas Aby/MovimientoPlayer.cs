using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Text Mensajes;
    public Animator anim;


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

        if (desplazamiento == Vector3.zero)
        {
            anim.SetBool("Run", false);
        }
        else
        {
            anim.SetBool("Run", true);
        }

    }
    void ResetearText()
    {
        Mensajes.text = "";
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.transform.tag == "Domo")
        {
            FindObjectOfType<PlayerInterfaz>().RecibirGolpe();
        }      

        if (collision.collider.transform.tag == "BaseC")
        {
            var animCristal = Cristales.GetComponent<Animator>();
            animCristal.SetBool("Cristales", true);

            var animDomo = Domo.GetComponent<Animator>();
            animDomo.SetBool("Domo", true);
            
            Mensajes.text = "Recoge las municiones y destruye a los enemigos, puedes cambiar de arma con 1 y 2";
            Invoke("ResetearText",2f);            
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.transform.tag == "Pad")
        {
            Mensajes.text = "Consigue los cristales y el arma para desactivar el Domo. Puedes cambiar de arma con las teclas 1 y 2";
            Invoke("ResetearText", 2f);
        }       
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Cristales_Domo")
        {
            CristalDomo++;
            Destroy(other.transform.gameObject);                        
        }

        if (CristalDomo >= 3)
        {
            Mensajes.text = "Dirigite a la base inicial para desactivar el Domo.";
            Invoke("ResetearText", 2f);

            var anim = BaseC.GetComponent<Animator>();
            anim.SetBool("BasesCristales",true);
            Destroy(Pad);
        }        
    }
}
