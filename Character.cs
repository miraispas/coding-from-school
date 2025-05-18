using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float health;

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        IsDead();
    }

    public virtual void IsDead()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
