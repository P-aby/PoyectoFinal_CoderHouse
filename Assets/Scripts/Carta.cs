using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevaCarta",menuName = "Carta")]
public class Carta : ScriptableObject
{
    public string nombre;
    public string Descripcion;    
    

    public void MostrarData()
    {
        Debug.Log(nombre + Descripcion);
    }
}
