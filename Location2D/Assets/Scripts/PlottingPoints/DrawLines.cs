using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{

    //Coordinates point = new Coordinates(10,20);

    Coordinates startPointY = new Coordinates(0,100);
    Coordinates endPointY = new Coordinates(0, -100);

    Coordinates startPointX = new Coordinates(160, 0);
    Coordinates endPointX = new Coordinates(-160, 0);

    Coordinates[] leo =
    {
        new Coordinates(0,20),
        new Coordinates(20,30),
        new Coordinates(80,30),
        new Coordinates(30,50),
        new Coordinates(80,50),
        new Coordinates(70,60),
        new Coordinates(70,80),
        new Coordinates(80,90),
        new Coordinates(95,80)

    };

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(point.ToString());
        //Coordinates.DrawPoint(new Coordinates(0,0),2,Color.red);
        //Coordinates.DrawPoint(point,2,Color.yellow);

        Coordinates.DrawLine(startPointY,endPointY,4,Color.green);
        Coordinates.DrawLine(startPointX, endPointX, 3, Color.red);


        foreach(Coordinates c in leo )
        {
            Coordinates.DrawPoint(c, 2, Color.yellow);
        }

        Coordinates.DrawLine(leo[0],leo[1],0.5f,Color.white);
        Coordinates.DrawLine(leo[1], leo[2], 0.5f, Color.white);
        Coordinates.DrawLine(leo[0], leo[3], 0.5f, Color.white);
        Coordinates.DrawLine(leo[3], leo[5], 0.5f, Color.white);
        Coordinates.DrawLine(leo[2], leo[4], 0.5f, Color.white);
        Coordinates.DrawLine(leo[4], leo[5], 0.5f, Color.white);
        Coordinates.DrawLine(leo[5], leo[6], 0.5f, Color.white);
        Coordinates.DrawLine(leo[6], leo[7], 0.5f, Color.white);
        Coordinates.DrawLine(leo[7], leo[8], 0.5f, Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
