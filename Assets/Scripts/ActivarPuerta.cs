using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarPuerta : MensajesUI
{
    public GameObject Key;
    public GameObject KeyUI;
    public GameObject postProcess1;
    public GameObject postProcess2;
    public GameObject portalTrigger;
    public GameObject SphereReflect;

    public void DestruirKey()
    {
        Destroy(Key);
        KeyUI.SetActive(true);
        Mensajes.text = "Ya tienes la llave, busca el Area 02";
        Invoke("ResetearText", 10f);
        portalTrigger.SetActive(true);
        SphereReflect.SetActive(true);
    }
    public void CargarEscena()
    {
        SceneManager.LoadScene(4);
    }

    public void PostProcessing()
    {
        postProcess1.SetActive(false);
        postProcess2.SetActive(true);
    }


}
