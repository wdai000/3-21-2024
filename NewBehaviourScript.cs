using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int counter;
    int NumberOfGems;

    bool DoorIsLocked = true;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;

        NumberOfGems = 0;

        /*
        while(NumberOfGems < 100)
        {
            Debug.Log("You have not collected enough gems yet.");
            NumberOfGems++;
        }
        */

        /*
        for(int i = 0; i < 100; i++)
        {
            Debug.Log("Value of i: " + i);
        }

        Debug.Log("You won.");
        */

        while(DoorIsLocked)
        {
            DoorIsLocked = false;
        }



    }

    // Update is called once per frame
    void Update()
    {
       /* counter++;
        Debug.Log("Counter : " + counter);
       */
    }
}
