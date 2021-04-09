using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOwnMathematics : MonoBehaviour
{

    static public float Square(float value)
    {
        return value * value;
    }

    static public float Distance(TestNormalCoordinates point2,TestNormalCoordinates point1)
    {
        float distance = Mathf.Sqrt(Square(point2.x - point1.x) + Square(point2.y - point1.y));

        return distance;

        //float differenceSquare = Square(point2.x - point1.x) +
        //                         Square(point2.y - point1.y) +
        //                         Square(point2.z - point1.z);

        //float squareRoot = Mathf.Sqrt(differenceSquare);

        //return squareRoot;

    }

    static public TestNormalCoordinates GetNormal(TestNormalCoordinates tankVector)
    {
        float length = Distance(new TestNormalCoordinates(0,0,0),tankVector);
        tankVector.x /= length;
        tankVector.y /= length;
        tankVector.z /= length;

        return tankVector;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public float DotProduct(TestNormalCoordinates vector2,TestNormalCoordinates vector1)
    {
        float product = (vector2.x * vector1.x) + (vector2.y * vector1.y) + (vector2.z *  vector1.z);

        return product;
    }

    static public float Angle(TestNormalCoordinates vector2,TestNormalCoordinates vector1)
    {
        float dotDivide = DotProduct(vector2, vector1) / (Distance(new TestNormalCoordinates(0,0,0),vector2) * Distance(new TestNormalCoordinates(0,0,0),vector1));

        Debug.Log("DOR PRODUCT WITHOUT ANGLE: " + dotDivide);

        float angle = Mathf.Acos(dotDivide);

        return angle; // radians /to convert radians to dregress * 180 / Mathf.PI;
    }


}
