using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float health = 10;

    public void TakeDamage(float Damage)
    {
        health -= Damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }

    }
}
