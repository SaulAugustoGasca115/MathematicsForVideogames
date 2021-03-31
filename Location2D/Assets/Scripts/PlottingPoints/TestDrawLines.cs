using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrawLines : MonoBehaviour
{
    TestCoordinates startPointY = new TestCoordinates(0,100,-1);
    TestCoordinates endPointY = new TestCoordinates(0,-100,-1);

    TestCoordinates startPointX = new TestCoordinates(160, 0, -1);
    TestCoordinates endPointX = new TestCoordinates(-160, 0, -1);


    TestCoordinates p = new TestCoordinates(10, 20, -1);

    TestCoordinates[] points =
    {
        new TestCoordinates(20,10,-1),
        new TestCoordinates(25,35,-1),
        new TestCoordinates(50,35,-1)
    };

    // Start is called before the first frame update
    void Start()
    {
        p.ToString();
        TestCoordinates.DrawPoint(new TestCoordinates(5,50,-1),5,Color.yellow);
        TestCoordinates.DrawPoint(new TestCoordinates(100, 0, -1), 5, Color.blue);

        TestCoordinates.DrawLine(startPointY,endPointY,3,Color.green);
        TestCoordinates.DrawLine(startPointX, endPointX, 3, Color.red);


        foreach(TestCoordinates tc in points)
        {
            TestCoordinates.DrawPoint(tc,5,Color.gray);
        }

        TestCoordinates.DrawLine(points[0],points[1],3,Color.white);
        TestCoordinates.DrawLine(points[1],points[2],3,Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
