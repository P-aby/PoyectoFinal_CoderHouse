using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TDA_Objetivos : MonoBehaviour
{
   
    //public static bool guntaken;
    Queue objetivos = new Queue();
    void Start()
    {
        objetivos.Enqueue("Busca el arma");
        objetivos.Enqueue("Recolecta el primer cristal");
        objetivos.Enqueue("Recolecta el segundo cristal");
        objetivos.Enqueue("Recolecta el tercer cristal");
        objetivos.Enqueue("Regresa a la base inicial");
        objetivos.Enqueue("Destruye a los enemigos");
        objetivos.Enqueue("Toma la llave");
        objetivos.Enqueue("Busca el área 2");


        Debug.Log(objetivos.Peek());
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    public void RecorrerLista()
    {
        objetivos.Dequeue();
        Debug.Log(objetivos.Peek());
    }
   
}
