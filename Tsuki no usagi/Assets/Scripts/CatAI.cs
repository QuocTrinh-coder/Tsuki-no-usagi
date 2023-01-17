using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatAI : MonoBehaviour
{
    public float speed;
    public float minPlayerDistance;
    public float visionDistance;

    //public bool zodiacSpotted = false;
    //public bool pigTakeOver = false;

    public GameObject cat;

    //public MeshRenderer meshRenderer;

    public Transform player;
    //public Transform pig; // This is lazy but we have no choice T_T

    //private PigAI pigAI;

    private void Start()
    {
        //pigAI = GetComponent<PigAI>();
        //meshRenderer = GetComponent<MeshRenderer>();
        cat = GameObject.Find("Cat");
    }

    private void Update()
    {
        //if (!pigTakeOver)
        //{
            //if (Vector3.Distance(transform.position, pig.position) <= 1)
            //{
            //    pigTakeOver = true;
            //}
            //else if (Vector3.Distance(transform.position, pig.position) <= visionDistance) ChaseZodiac();

            if (Vector3.Distance(transform.position, player.position) < minPlayerDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }

        //}
        //else
        //{
        //    //pigAI.takeOver = true;
        //    cat.GetComponent<MeshRenderer>().enabled = false;
        //}
        
    }

    //private void ChaseZodiac()
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, pig.position, speed * Time.deltaTime);
    //}
}