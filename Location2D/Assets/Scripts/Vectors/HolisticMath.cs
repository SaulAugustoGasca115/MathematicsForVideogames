using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolisticMath
{

    static public NormalCoordinates GetNormal(NormalCoordinates vector)
    {
        float length = GetDistance(new NormalCoordinates(0, 0, 0), vector);
        vector.x /= length;
        vector.y /= length;
        vector.z /= length;

        return vector;
    }


    static public float GetDistance(NormalCoordinates point1,NormalCoordinates point2)
    {
        //float distance = Vector3.Distance(point1.ToVector(), point2.ToVector());

        //return distance;

        float differenceSquare = Square(point1.x - point2.x) +
                                 Square(point1.y - point2.y) +
                                 Square(point1.z - point2.z);

        float squareRoot = Mathf.Sqrt(differenceSquare);

        return squareRoot;
    }

    static public float Square(float value)
    {
        return value * value;
    }

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    //** Dot product section
    static public float Dot(NormalCoordinates vector1,NormalCoordinates vector2)
    {
        //float dotProduct = (vector1.x * vector2.x) + (vector1.y * vector2.y);

        //return dotProduct;

        return (vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z);
    }

    static public float Angle(NormalCoordinates vector1, NormalCoordinates vector2)
    {
        float dotDivide = Dot(vector1, vector2) / (GetDistance(new NormalCoordinates(0, 0, 0), vector1) * GetDistance(new NormalCoordinates(0, 0, 0), vector2));

        return Mathf.Acos(dotDivide); //radians  //for degrees multiply * 180 / Mathf.PI;
    }

    static public NormalCoordinates Rotate(NormalCoordinates vector,float angle) //angle in radians
    {
        float xValue = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);

        float yValue = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);

        return new NormalCoordinates(xValue,yValue,0);
    }

}
