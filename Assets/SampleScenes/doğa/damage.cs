using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int Hurt = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 damageDirection = collision.transform.position + transform.position;
            damageDirection = damageDirection.normalized;
            FindObjectOfType<playerhealth>().DamagePlayer(Hurt, damageDirection);
        }
    }
}
