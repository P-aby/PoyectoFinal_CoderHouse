using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCarta : MonoBehaviour
{
    public Carta _carta;
    public Carta _cartaEnemy;
    public Text textoDescripción;
    public Text textoNombre;
    public GameObject Personaje;
    public GameObject personajeEnemy;

   
    void Start()
    {
               

    }
    public void Update()
    {
        DatosCarta();
    }

    public void Button()
    {
        Personaje.SetActive(false);
        personajeEnemy.SetActive(true);
        _carta = _cartaEnemy;

    }
    void DatosCarta()
    {
        textoDescripción.text = _carta.Descripcion;
        textoNombre.text = _carta.nombre;
    }
   

    


}
