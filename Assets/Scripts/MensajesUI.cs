using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MensajesUI : MonoBehaviour
{
    public Text Mensajes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void ResetearText()
    {
        Mensajes.text = "";
    }
}
