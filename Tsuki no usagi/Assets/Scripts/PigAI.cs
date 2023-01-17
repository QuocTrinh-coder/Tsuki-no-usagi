using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PigAI : MonoBehaviour
{
    public float speed;
    public bool chasePlayer;
    public float waitTime;
    public float minPlayerDistance;

    private bool waitDone = true;

    private void Start()
    {
        chasePlayer = false;
        EventTrigger trigger = GetComponent<EventTrigger>();
    }

    // Update is called once per frame
    private void Update()
    {
        // check if collided
        //if (chasePlayer && waitDone)
        if(chasePlayer)
        {
            Debug.Log("Move pig");
            //waitDone = false;

            Charge();
            /* if (Vector3.Distance(transform.position, player.position) > minPlayerDistance)
             {
                 Charge();
             }
             else
             {
                 //Stomp();
             }*/
            StartCoroutine(Wait());

            // if jump, escape
            if (Input.GetKey(KeyCode.Space))
            {
                chasePlayer = false;
            }
        }
    }

    IEnumerator Wait()
    {  
        yield return new WaitForSeconds(waitTime);
        waitDone = true;
    }

    // if collide into player, then chase player
    private void OnCollisionEnter(Collision collision)
    {
        chasePlayer = true;
        Debug.Log("Hit Pig");
    }

    // follow player
    private void Charge()
    {
        Transform player = (GameObject.Find("Player")).GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, player.position, .01f);
        //transform.position = Vector3.MoveTowards(transform.position, player.position, 5f * speed * Time.deltaTime);
    }

    private void Stomp()
    {
        
    }
}
