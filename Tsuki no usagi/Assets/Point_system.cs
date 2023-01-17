using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_system : MonoBehaviour
{
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10,10,1000,2000), "Score : " + points);
    }
}
