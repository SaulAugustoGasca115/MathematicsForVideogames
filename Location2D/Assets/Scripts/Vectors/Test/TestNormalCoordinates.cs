using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNormalCoordinates : MonoBehaviour
{

    [Header("Normal Coordinates")]
    public float x;
    public float y;
    public float z;


    public TestNormalCoordinates(float x,float y)
    {
        this.x = x;
        this.y = y;
        this.z = -1;
    }


    public TestNormalCoordinates(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }


    public Vector3 ConvertToVector()
    {
        return new Vector3(x, y, z);
    }

    public TestNormalCoordinates(Vector3 vectorPosition)
    {
        x = vectorPosition.x;
        y = vectorPosition.y;
        z = vectorPosition.z;
    }

    public override string ToString()
    {
        return "( " + x + " , " + y + " , " + z + " )";
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
