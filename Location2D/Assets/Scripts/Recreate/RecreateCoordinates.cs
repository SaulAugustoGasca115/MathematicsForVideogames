using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecreateCoordinates : MonoBehaviour
{
    [Header("Recreate Coordinates")]
    public float x;
    public float y;
    public float z;


    public RecreateCoordinates(float x,float y)
    {
        this.x = x;
        this.y = y;
        z = -1;
    }

    public RecreateCoordinates(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3 ConvertToVector()
    {
        return new Vector3(x,y,z);
    }

    public RecreateCoordinates(Vector3 vectorPoint)
    {
        this.x = vectorPoint.x;
        this.y = vectorPoint.y;
        this.z = vectorPoint.z;
    }


    public override string ToString()
    {
        return "( " + x + " , " + y + " , " + z + " )";

    }


}
