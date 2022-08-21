using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    
    void Start()
    {
        Eventos.ejemploEventos += cambiarColor;
    }

    void Update()
    {
        
    }
    void cambiarColor()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    
}
