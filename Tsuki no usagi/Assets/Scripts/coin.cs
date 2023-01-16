using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    public int points = 0;
    private GameObject koin = GameObject.Find("Coin");

    private void OnCollisionEnter(Collision collision)
    {
        points++;
        koin.GetComponent<MeshRenderer>().enabled = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
