using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinates : MonoBehaviour
{
    float x;
    float y;
    float z;

    public Coordinates(float _X,float _Y)
    {
        x = _X;
        y = _Y;
        z = -1;
    }

    public override string ToString()
    {
        return "( " + x + " , " + y + " , " + z + ")";
    }

    public static void DrawPoint(Coordinates position,float width,Color colour)
    {
        GameObject line = new GameObject("Point: " + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(position.x - width / 3.0f,position.y - width / 3.0f,position.z));
        lineRenderer.SetPosition(1, new Vector3(position.x + width / 3.0f, position.y + width / 3.0f, position.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }

    public static void DrawLine(Coordinates startPoint,Coordinates endPoint,float width, Color colour)
    {
        GameObject line = new GameObject("Line: " + startPoint.ToString() + "_" + endPoint.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPoint.x,startPoint.y,startPoint.z));
        lineRenderer.SetPosition(1, new Vector3(endPoint.x,endPoint.y,endPoint.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
}
