﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Interfaz_Inicio : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonInicio()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonCharacter()
    {
        SceneManager.LoadScene(3);
    }
    public void ButtonMenuInicio()
    {
        SceneManager.LoadScene(0);
    }

 
}
