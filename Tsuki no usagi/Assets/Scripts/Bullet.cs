using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            if (collision.gameObject.layer != 8)
            {
                Destroy(collision.gameObject);
            }
            Destroy(gameObject);
        }        
    }
}
