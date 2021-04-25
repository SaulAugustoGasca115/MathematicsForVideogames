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

    static public TestNormalCoordinates Rotate(TestNormalCoordinates vector,float angle,bool clockwise)
    {
        if(clockwise)
        {
            angle = 2 * Mathf.PI - angle;
        }


        float xRotationValue = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);
        float yRotationValue = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);

        return new TestNormalCoordinates(xRotationValue,yRotationValue,0);
    }

    static public TestNormalCoordinates Cross(TestNormalCoordinates vVector,TestNormalCoordinates wVector)
    {
        float xCrossValue = vVector.y * wVector.z - vVector.z * wVector.y;
        float yCrossValue = vVector.z * wVector.x - vVector.x * wVector.z;
        float zCrossValue = vVector.x * wVector.y - vVector.y * wVector.x;

        return new TestNormalCoordinates(xCrossValue, yCrossValue, zCrossValue);
    }


    static public TestNormalCoordinates LookAt2D(TestNormalCoordinates forwardVector,TestNormalCoordinates position,TestNormalCoordinates focusPoint)
    {
        TestNormalCoordinates direction = new TestNormalCoordinates(focusPoint.x - position.x, focusPoint.y - position.y, position.z);
        float angle = Angle(forwardVector, direction);

        bool clockwise = false;

        if(Cross(forwardVector,direction).z < 0 )
        {
            clockwise = true;
        }

        TestNormalCoordinates newRotationDirection = Rotate(forwardVector, angle, clockwise);

        return newRotationDirection;

    }


}
