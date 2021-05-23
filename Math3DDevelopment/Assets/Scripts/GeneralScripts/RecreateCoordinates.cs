using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecreateCoordinates : MonoBehaviour
{
    [Header("Recreate Coordinates")]
    public float x;
    public float y;
    public float z;
    public float w;


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

    public RecreateCoordinates(float x,float y,float z,float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
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

    public RecreateCoordinates(Vector3 vectorPoint,float w)
    {
        this.x = vectorPoint.x;
        this.y = vectorPoint.y;
        this.z = vectorPoint.z;
        this.w = w;
    }


    public float[] AsFloats()
    {
        float[] values = { x, y, z, w };

        return values;
    }

    public override string ToString()
    {
        return "( " + x + " , " + y + " , " + z + " )";

    }

    public static RecreateCoordinates operator+ (RecreateCoordinates a,RecreateCoordinates b)
    {
        RecreateCoordinates c = new RecreateCoordinates(a.x + b.x,a.y + b.y,a.z + b.z);

        return c;

    }

    public static RecreateCoordinates operator- (RecreateCoordinates a, RecreateCoordinates b)
    {
        RecreateCoordinates c = new RecreateCoordinates(a.x - b.x, a.y - b.y, a.z - b.z);

        return c;
    }

    public static RecreateCoordinates Perpendiculare(RecreateCoordinates vector)
    {

        return new RecreateCoordinates(-vector.y, vector.x); 
    }

    public static void DrawLine(RecreateCoordinates startPoint,RecreateCoordinates endPoint,float width, Color color)
    {
        GameObject line = new GameObject("Line: " + startPoint.ToString() + " , " + endPoint.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = color;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPoint.x,startPoint.y,startPoint.z));
        lineRenderer.SetPosition(1,new Vector3(endPoint.x,endPoint.y,endPoint.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }


}
