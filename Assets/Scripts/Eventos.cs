using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Eventos : MonoBehaviour
{
    public static event Action ejemploEventos;
    public static event Action ejemploEventos2;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ejemploEventos?.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
            ejemploEventos2?.Invoke();
        }


    }
    


}
