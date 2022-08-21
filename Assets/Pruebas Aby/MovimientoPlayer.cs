using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoPlayer : MensajesUI
{
    public Vector3 desplazamiento;
    public float speed;
    public float vida;
    public Animator anim;    
    public Rigidbody rb;

    void Start()
    {
        
    }
    
    void Update()
    {
        
        Disparo();
        Movimiento();
    }

    private void FixedUpdate()
    {
       // Movimiento();
    }
    void Movimiento()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        float rot = Input.GetAxis("Mouse X");

       desplazamiento = new Vector3(hor, 0, ver);
       //rb.AddForce(desplazamiento * speed, ForceMode.Acceleration);
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
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.transform.tag == "Obstaculo")
        {
           anim.SetBool("Hit", false);
        }
    }
   public void Disparo()
    {
        if(Input.GetButton("Fire1"))
        {
            anim.SetBool("Gun", true);
        }
        else
        {
            anim.SetBool("Gun", false);
        }        
    }   

}
