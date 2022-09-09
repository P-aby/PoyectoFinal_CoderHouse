using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DomoCristales : MensajesUI
{
    public GameObject Domo;
    public GameObject Cristales;
    public int CristalDomo;
    public GameObject Pad_;
    public GameObject BaseC;
    public GameObject cristalRojo;
    public GameObject cristalAzul;
    public GameObject cristalAmarillo;
    public GameObject cRojo;
    public GameObject cAzul;
    public GameObject cAmarillo;
    public GameObject SphereReflectOut;
    public GameObject laberinto;


    public void DomoActive()
    {
        FindObjectOfType<PlayerInterfaz>().RecibirGolpe();

    }
    public void CristalesActive()
    {
        var animCristal = Cristales.GetComponent<Animator>();
            animCristal.SetBool("Cristales", true);

        var animDomo = Domo.GetComponent<Animator>();
        animDomo.SetBool("Domo", true);
        laberinto.SetActive(true);

        Mensajes.text = "Recoge las municiones y destruye a los enemigos, puedes cambiar de arma con 1 y 2";
        Invoke("ResetearText", 10);
    }
    public void Pad()
    {
        Mensajes.text = "Consigue los 3 cristales y el arma para desactivar el Domo. Puedes cambiar de arma con las teclas 1 y 2";
        Invoke("ResetearText", 10f);
    }

    public void CristalRojo()
    {
        CristalDomo++;
        Destroy(cristalRojo);
        Mensajes.text = "Ya tienes " + CristalDomo + "/3 cristales";
        Invoke("ResetearText", 4f);
        cRojo.SetActive(true);
    }
    public void CristalAzul()
    {
        CristalDomo++;
        Destroy(cristalAzul);
        Mensajes.text = "Ya tienes " + CristalDomo + "/3 cristales";
        Invoke("ResetearText", 4f);
        cAzul.SetActive(true);

    }
    public void CristalAmarillo()
    {
        CristalDomo++;
        Destroy(cristalAmarillo);
        Mensajes.text = "Ya tienes " + CristalDomo + "/3 cristales";
        Invoke("ResetearText", 4f);
        cAmarillo.SetActive(true);
    }

    public void RecolectarCristales()
    {
        if (CristalDomo >= 3)
        {
            Mensajes.text = "Dirigite a la base inicial para desactivar el Domo.";
            Invoke("ResetearText", 4f);

            var anim = BaseC.GetComponent<Animator>();
            anim.SetBool("BasesCristales", true);
            Destroy(Pad_);
            SphereReflectOut.SetActive(false);
        }
    } 
}
