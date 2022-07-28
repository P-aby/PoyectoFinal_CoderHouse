using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
  
    public float health = 20;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy1")
        {
            health = health - 1;
            if (health <= 0)
            {
                Debug.Log("Game over man, game over");
                SceneManager.LoadScene(1);
              
            }

        }
    }
}
