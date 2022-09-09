using UnityEngine;

public class Gun_ : MonoBehaviour
{
    public float range = 100f;
    public Camera fpsCam;

    
    public ParticleSystem Flash1;
    public AudioSource AudioHit;
    public AudioSource AudioShoot;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hit,range))
        {
            if(hit.transform.tag == "Enemy1")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }


}
