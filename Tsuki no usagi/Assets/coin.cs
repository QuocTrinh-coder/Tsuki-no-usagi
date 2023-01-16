using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    // public int points = 0;
    // private GameObject koin = GameObject.Find("Coin");

    // private void OnCollisionEnter(Collision collision)
    // {
    //     points++;
    //     koin.GetComponent<MeshRenderer>().enabled = false;
    // }


    // Start is called before the first frame update
    void update()
    {
        transform.Rotate(0,90 * Time.deltaTime,0);

    }
    private void OnTriggerEnter( Collider other)
    {
        if (other.name == "thirdpersonmovement")
        {
            other.GetComponent<Point_system>().points++;
            Destroy(gameObject); // this destroy thing
            tracking.instance.AddPoint();
        }
    }
}
