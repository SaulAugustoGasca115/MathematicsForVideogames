using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrawGraph : MonoBehaviour
{
    [Header("Draw Graph Attributes")]
    public float size = 20;
    public int xmax = 160;
    public int ymax = 100;

    // Start is called before the first frame update
    void Start()
    {
        DrawGraph();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DrawGraph()
    {
        TestCoordinates startPositionX = new TestCoordinates(-xmax,0,0);
        TestCoordinates endPositionX = new TestCoordinates(xmax, 0, 0);

        TestCoordinates startPositionY = new TestCoordinates(0,-ymax,0);
        TestCoordinates endPositionY = new TestCoordinates(0, ymax, 0);

        //TestCoordinates.DrawLine(startPositionX, endPositionX, 1, Color.white);

        //TestCoordinates.DrawLine(startPositionY, endPositionY, 1, Color.white);


        int xoffset = (int)(xmax / size);

        int yoffset = (int)(ymax / size);

        //for (int x = -xmax; x <= xmax; x += (int)size)
        //{
        //    TestCoordinates.DrawLine(new TestCoordinates(x, -ymax, 0), new TestCoordinates(x, ymax, 0), 1, Color.white);
        //}

        //for (int y = -ymax; y <= ymax; y += (int)size)
        //{
        //    TestCoordinates.DrawLine(new TestCoordinates(-xmax, y, 0), new TestCoordinates(xmax, y, 0), 1, Color.white);
        //}

        for (int x = -xoffset * (int)size; x <= xmax; x += (int)size)
        {
            TestCoordinates.DrawLine(new TestCoordinates(x, -ymax, 0), new TestCoordinates(x, ymax, 0), 1, Color.white);
        }

        for (int y = -yoffset * (int)size; y <= ymax; y += (int)size)
        {
            TestCoordinates.DrawLine(new TestCoordinates(-xmax, y, 0), new TestCoordinates(xmax, y, 0), 1, Color.white);
        }
    }
}
