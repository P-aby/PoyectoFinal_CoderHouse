using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInterfaz : MonoBehaviour
{

    public Image Barravida;
    public float vidaUI;  
    public AudioSource hit;
    public Animator anim;
    public GameObject panelPause;

    void Start()
    {
        vidaUI = 100;
        Barravida.fillAmount = 1;

    }
    public void RecibirGolpe()
    {
        vidaUI = vidaUI - 5;
        Barravida.fillAmount = vidaUI / 100;
        hit.Play();        
        anim.SetBool("Hit", true);


        if (vidaUI == 00)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void ButtonRestart()
    {
        vidaUI = 100;
        Time.timeScale = 1;
        panelPause.SetActive(false);
        SceneManager.LoadScene(1);

    }

}
