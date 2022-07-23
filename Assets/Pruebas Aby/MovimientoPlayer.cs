using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public Vector3 desplazamiento;
    public float speed;
    public GameObject prefabBala;
    public Transform arma;
    public float tiempobala;
    public float FuerzaBala;
    public float vida;
    public int CristalDomo;
    public GameObject Domo;
    public GameObject BaseC;
    public GameObject Cristales;

    void Start()
    {
        
    }
    
    void Update()
    {
        Movimiento();
        InstanciarBala();
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
    void InstanciarBala()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject balaAuxiliar = Instantiate(prefabBala, arma.position + transform.forward * 1, Quaternion.identity);
            balaAuxiliar.GetComponent<Rigidbody>().AddForce(transform.forward * FuerzaBala);
            Destroy(balaAuxiliar, tiempobala);
        }
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
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Cristales_Domo")
        {
            Destroy(other.transform.gameObject);
            CristalDomo++;
            Debug.Log("Tienes: " + CristalDomo + " Cristales para desactivar el Domo");
        }

        if (CristalDomo == 3)
        {
            Debug.Log("Dirigete a la base para colocar los cristales");
           
            var anim = BaseC.GetComponent<Animator>();
            anim.SetBool("BasesCristales", true);
        }



        
    }
}
