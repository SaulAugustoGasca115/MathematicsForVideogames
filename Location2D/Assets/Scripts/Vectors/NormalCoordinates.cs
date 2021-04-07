using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalCoordinates : MonoBehaviour
{

    public float x;
    public float y;
    public float z;

    public NormalCoordinates(float x ,float y)
    {
        this.x = x;
        this.y = y;
        this.z = -1;
    }

    public NormalCoordinates(float x, float y,float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public NormalCoordinates(Vector3 vectorposition)
    {
        x = vectorposition.x;
        y = vectorposition.y;
        z = vectorposition.z;
    }

    public override string ToString()
    {
        return "( " + x + " , " + y + " , " + z + " )";
    }

    public Vector3 ToVector()
    {
        return new Vector3(x,y,z);
    }

    public static void DrawPoint(NormalCoordinates position,float width,Color color)
    {
        GameObject point = new GameObject("Point: " + position.ToString());
        LineRenderer line = point.AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Unlit/Color"));
        line.material.color = color;
        line.SetPosition(0,new Vector3(position.x - width / 3.0f, position.y - width / 3.0f,position.z));
        line.SetPosition(1, new Vector3(position.x + width / 3.0f, position.y + width / 3.0f, position.z));
        line.startWidth = width;
        line.endWidth = width;
    }

    public static void DrawLine(NormalCoordinates startPosition,NormalCoordinates endPosition,float width, Color color)
    {
        GameObject line = new GameObject("Line: " + startPosition.ToString() + " _ " + endPosition.ToString());
        LineRenderer linerenderer = line.AddComponent<LineRenderer>();
        linerenderer.material = new Material(Shader.Find("Unlit/Color"));
        linerenderer.material.color = color;
        linerenderer.SetPosition(0, new Vector3(startPosition.x, startPosition.y, startPosition.z));
        linerenderer.SetPosition(1, new Vector3(endPosition.x,endPosition.y, endPosition.z));
        linerenderer.startWidth = width;
        linerenderer.endWidth = width;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
