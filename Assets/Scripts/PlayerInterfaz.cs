using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInterfaz : MonoBehaviour
{
    public Image Barravida;
    public float vida;
    public GameObject panelPause;
    public GameObject cRojo;
    public GameObject cAzul;
    public GameObject cAmarillo;
    public AudioSource hit;
   

    void Start()
    {
        vida = 100;
        Barravida.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RecibirGolpe()
    {
        vida = vida - 5;
        Barravida.fillAmount = vida / 100;
        hit.Play();
        

        if (vida == 00)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;
        }

    } 
    public void ButtonRestart()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "CristalRojo")
        {
            cRojo.SetActive(true);
        }
        if (other.transform.name == "CristalAzul")
        {
            cAzul.SetActive(true);
        }
        if (other.transform.name == "CristalAmarillo")
        {
            cAmarillo.SetActive(true);
        }
    }
   
    

}
