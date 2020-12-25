using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    void Start()
    {
        int[] points = new int[5];

        points[0] = 90;
        points[1] = 70;
        points[2] = 50;
        points[3] = 30;
        points[4] = 10;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }


        Boss1 midboss = new Boss1();

        midboss.Attack();

        for (int i = 33; i >= 3; i--)
        {
            midboss.Magic();
        }

        midboss.Defence(1);

        Boss lastboss = new Boss();

        lastboss.Attack();

       for(int i = 53; i >= 3; i--){
            lastboss.Magic();
        }

        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
