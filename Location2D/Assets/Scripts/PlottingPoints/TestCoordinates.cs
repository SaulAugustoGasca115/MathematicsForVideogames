using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoordinates : MonoBehaviour
{

    [Header("Coordinates Variables")]
    float x;
    float y;
    float z;


    public TestCoordinates(float x,float y,float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override string ToString()
    {
        return "( " + x + " , " + y + " , " + z + " )";
    }

    public static void DrawPoint(TestCoordinates position,float width,Color colour)
    {
        GameObject line = new GameObject("Point: " + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(position.x - width / 3.0f,position.y - width / 3.0f,position.z));
        lineRenderer.SetPosition(1,new Vector3(position.x + width / 3.0f, position.y + width / 3.0f, position.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }

    public static void DrawLine(TestCoordinates startPoint,TestCoordinates endPosition,float width,Color colour)
    {
        GameObject line = new GameObject("Line: " + startPoint.ToString() + " _ " + endPosition.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPoint.x, startPoint.y, startPoint.z));
        lineRenderer.SetPosition(1, new Vector3(endPosition.x, endPosition.y, endPosition.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }

}
