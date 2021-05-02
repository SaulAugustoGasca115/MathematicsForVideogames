using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRecreateMathemathics 
{
    //Normal Vector
    public static float Square(float value)
    {
        return value * value;
    }

    public static float Distance(RecreateCoordinates vector1,RecreateCoordinates vector2)
    {
        float differenceDistance = Square(vector1.x - vector2.x) + Square(vector1.y - vector2.y) + Square(vector1.z - vector2.z);

        return Mathf.Sqrt(differenceDistance);
    }

    public static RecreateCoordinates NormalVector(RecreateCoordinates vector)
    {
        float length = Distance(new RecreateCoordinates(0,0,0),vector);

        vector.x /= length;
        vector.y /= length;
        vector.z /= length;

        return vector;
    }

    public static float DotProduct(RecreateCoordinates vector1,RecreateCoordinates vector2)
    {
        return (vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z);
    }

    public static float Angle(RecreateCoordinates vector1,RecreateCoordinates vector2)
    {
        float angle = DotProduct(vector1, vector2) / Distance(new RecreateCoordinates(0, 0, 0), vector1) * Distance(new RecreateCoordinates(0,0,0),vector2);

        return Mathf.Acos(angle);
    }

    public static RecreateCoordinates Rotate(RecreateCoordinates vector,float angle,bool clockwise)
    {
        if(clockwise)
        {
            angle = 2 * Mathf.PI - angle; // this method works in radians and 2 * Math.PI is equal to 360 degress of a circle
        }

        float xRotationValue = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);

        float yRotationValue = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);

        return new RecreateCoordinates(xRotationValue,yRotationValue,0.0f);

    }

    public static RecreateCoordinates CrossProduct(RecreateCoordinates vector1,RecreateCoordinates vector2)
    {
        float xCrossValue = vector1.y * vector2.z - vector1.z * vector2.y;
        float yCrossValue = vector1.z * vector2.x - vector1.x * vector2.z;
        float zCrossValue = vector1.x * vector2.y - vector1.y * vector2.x;

        return new RecreateCoordinates(xCrossValue,yCrossValue,zCrossValue);
    }


    //Create my own Translate
    public static RecreateCoordinates Translate(RecreateCoordinates position,RecreateCoordinates facing,RecreateCoordinates vector)
    {
        if(Distance(new RecreateCoordinates(0,0,0),vector) <= 0)
        {
            return position;
        }

        float angle = Angle(vector,facing);
        float worldAngle = Angle(vector, new RecreateCoordinates(0, 1, 0));

        bool clockwise = false;

        if(CrossProduct(vector,facing).z < 0)
        {
            clockwise = true;
        }

        vector = Rotate(vector,angle + worldAngle,clockwise);

        float xValue = position.x + vector.x;
        float yValue = position.y + vector.y;
        float zValue = position.z + vector.z;

        return new RecreateCoordinates(xValue,yValue,zValue);

    }
}
