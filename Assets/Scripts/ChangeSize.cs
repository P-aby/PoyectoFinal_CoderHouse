using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{

    void Start()
    {
        Eventos.ejemploEventos += IncreaseSize;
        Eventos.ejemploEventos2 += DecreaSize;
    }
    void IncreaseSize()
    {
        transform.localScale = new Vector3(3, 3, 3);
    }

    void OnDisable()
    {
        Eventos.ejemploEventos -= IncreaseSize;
        Eventos.ejemploEventos2 -= DecreaSize;
    }

    void DecreaSize()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }


}
