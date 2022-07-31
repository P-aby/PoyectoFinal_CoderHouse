using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDA_List : MonoBehaviour
{
    public List<string> cristales = new List<string>();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "CristalRojo")
        {
            Destroy(other.transform.gameObject);
            cristales.Add("Cristal rojo");
        }
        if (other.transform.name == "CristalAmarillo")
        {
            Destroy(other.transform.gameObject);
            cristales.Add("Cristal amarillo");
        }
        if (other.transform.name == "CristalAzul")
        {
            Destroy(other.transform.gameObject);
            cristales.Add("Cristal azul");
        }
    }
}