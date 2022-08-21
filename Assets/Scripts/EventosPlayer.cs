using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventosPlayer : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;
    [SerializeField] private UnityEvent myCollider;
    [SerializeField] private UnityEvent myColliderEnter;
    [SerializeField] private UnityEvent myColliderExit;


    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag =="Player")
        {
            myTrigger.Invoke();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            myColliderEnter.Invoke();
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            myCollider.Invoke();
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            myColliderExit.Invoke();
        }

    }

}
