using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private float health = 100f;
    public void Damage()
    {
        health -= 10f;
        if(health == 0f)
        {
            Destroy(gameObject);
        }
    }
}
