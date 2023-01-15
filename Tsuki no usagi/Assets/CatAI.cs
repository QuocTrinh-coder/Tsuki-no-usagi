using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAI : MonoBehaviour
{
    public float speed;
    public float minPlayerDistance;
    public float visionDistance;

    public bool zodiacSpotted = false;
    public Transform player;
    public Transform pig; // This is lazy but we have no choice T_T

    private void Update()
    {
        // Check if a zodiac animal is within vision
        //if (Vector3.Distance(transform.position, pig.position) <= visionDistance)
        //{
        //    zodiacSpotted = true;
        //}

        //if (zodiacSpotted)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        //}
        if (Vector3.Distance(transform.position, player.position) < minPlayerDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }
}