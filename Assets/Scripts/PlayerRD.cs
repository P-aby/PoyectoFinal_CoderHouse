using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRD : MonoBehaviour
{

    public float speed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        Mov();   
    }
    void Mov()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        float rot = Input.GetAxis("Mouse X");

        transform.Translate(new Vector3(hor, 0, ver) * speed * Time.deltaTime);
        transform.Rotate(0, rot, 0);

    }
}
