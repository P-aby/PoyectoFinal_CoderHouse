using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDA_Array : MonoBehaviour
{
    public int quantity = 10;
    public GameObject[] ammo;
    public GameObject Bullet1;
    public GameObject Gun1;
    
  
    void Start()
    {
       

        ammo = new GameObject[quantity];
        for (int i = 0; i < ammo.Length; i++)
        {
            GameObject go = Instantiate(Bullet1, new Vector3(Random.Range(-100, 100), 0, Random.Range(-50, 100)), Quaternion.identity);
            ammo[i] = go;
        }


    }

    
    
}
