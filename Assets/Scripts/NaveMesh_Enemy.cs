using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaveMesh_Enemy : MonoBehaviour
{
    [SerializeField] private GameObject pointer;
    public NavMeshAgent EnemyNaveMesh;
    public Transform TransformPointer;
    public Animator EnemyController;    
       
    void Update()
    {
        float dist = Vector3.Distance(transform.position, TransformPointer.position);

        if (dist < 60)
        {
           EnemyNaveMesh.destination = pointer.transform.position;
           EnemyController.SetBool("Run Forward", true);
        }
        else
        {
            EnemyController.SetBool("Run Forward", false);
        }

        if(dist < 5)
        {
            EnemyController.SetBool("Smash Attack", true);
        }
        else
        {
            EnemyController.SetBool("Smash Attack",false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<PlayerInterfaz>().RecibirGolpe();
        }
    }

}
