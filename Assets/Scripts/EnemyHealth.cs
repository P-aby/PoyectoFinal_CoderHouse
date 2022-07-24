using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float health = 2;
    public float DamageGiven = 2;

    public void TakeDamage(float Damage)
    {
        health -= Damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }

    }
}
