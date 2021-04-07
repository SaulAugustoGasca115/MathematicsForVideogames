using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    [Header("DrawGraph Attributes")]
    public int size = 20;
    public int xmax = 200;
    public int ymax = 200;

    //Coordinates startPositionX = new Coordinates(160,0);
    //Coordinates endPositionX = new Coordinates(-160, 0);

    //Coordinates startPositionY = new Coordinates(0, 100);
    //Coordinates endPositionY = new Coordinates(0, -100);

    // Start is called before the first frame update
    void Start()
    {

        Coordinates startPositionX = new Coordinates(xmax, 0);
        Coordinates endPositionX = new Coordinates(-xmax, 0);

        Coordinates startPositionY = new Coordinates(0, ymax);
        Coordinates endPositionY = new Coordinates(0, -ymax);


        //x axis
        Coordinates.DrawLine(startPositionX,endPositionX,1,Color.red);

        //y axis
        Coordinates.DrawLine(startPositionY,endPositionY,1,Color.green);

        //int xoffset = (int)(160 / (float)size);

        //int yoffset = (int)(100 / (float)size);

        int xoffset = (int)(xmax / (float)size);

        int yoffset = (int)(ymax / (float)size);

        //for(int x = -160;x <= 160;x += size)
        //{
        //    Coordinates.DrawLine(new Coordinates(x,-100),new Coordinates(x,100),0.5f,Color.white);
        //}

        //for(int y = -100;y<=100;y += size)
        //{
        //    Coordinates.DrawLine(new Coordinates(-160, y),new Coordinates(160,y),0.5f,Color.white);
        //}

        for (int x = -xoffset * size; x <= xoffset * size; x += size)
        {
            Coordinates.DrawLine(new Coordinates(x, -ymax), new Coordinates(x, ymax), 0.5f, Color.white);
        }

        for (int y = -yoffset * size; y <= yoffset *  size; y += size)
        {

            Coordinates.DrawLine(new Coordinates(-xmax, y), new Coordinates(xmax, y), 0.5f, Color.white);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
