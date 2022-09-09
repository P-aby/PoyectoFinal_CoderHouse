using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    public float tiempo = 30f;
    public GameObject panelPause;

    private void Update()
    {
        tiempo = tiempo - Time.deltaTime;
        if (tiempo <= 0)

        {
            panelPause.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
}
