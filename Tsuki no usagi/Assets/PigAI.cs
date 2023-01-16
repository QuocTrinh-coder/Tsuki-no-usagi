using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PigAI : MonoBehaviour
{
    public float speed;
    public bool takeOver;
    public float waitTime;
    public float minPlayerDistance;
    public Transform player;

    private bool waitDone = true;

    private void Start()
    {
        takeOver = false;
        EventTrigger trigger = GetComponent<EventTrigger>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (takeOver && waitDone)
        {
            Debug.Log("HI");
            waitDone = false;
            if (Vector3.Distance(transform.position, player.position) > minPlayerDistance)
            {
                Charge();
            }
            else
            {
                //Stomp();
            }
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {  
        yield return new WaitForSeconds(waitTime);
        waitDone = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cat")
        {
            takeOver = true;
        }
    }

    private void Charge()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 5f * speed * Time.deltaTime);
    }

    private void Stomp()
    {
        
    }
}
