using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    /* I put some more stuff in that we learned */

    void Hello()
    {
        Debug.Log("Hello World");
    }
    
    public int doors;
    public float cars;
    public string catname;
    public bool doginside;

    // Start is called before the first frame update
    void Start()
    {
        Hello();

        doginside = false;
        doors = 3;
        cars = 1;
        catname = "Mauzi";
    }

    // Update is called once per frame
    void Update()
    {
        if (doors == 20)
        {
            doginside = true;
        }

        else
        {
            doginside = false;
        }
    }
}
