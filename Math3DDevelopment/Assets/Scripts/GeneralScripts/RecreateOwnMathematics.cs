using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecreateOwnMathematics : MonoBehaviour
{
    public static float Square(float value)
    {
        return value * value;
    }

    public static float Distance(RecreateCoordinates point1,RecreateCoordinates point2)
    {
        float differenceSquare = Square(point1.x - point2.x)
                                 + Square(point1.y - point2.y)
                                 + Square(point1.z - point2.z);

        return Mathf.Sqrt(differenceSquare);
    }

    public static RecreateCoordinates Normal(RecreateCoordinates vector)
    {
        float length = Distance(new RecreateCoordinates(0,0,0),vector);

        vector.x /= length;
        vector.y /= length;
        vector.z /= length;

        return vector;
    }



    //Dot Product
    public static float DotProduct(RecreateCoordinates vector1,RecreateCoordinates vector2)
    {
        return (vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z);
    }

    public static float Angle(RecreateCoordinates vector1,RecreateCoordinates vector2)
    {
        float dotDivided = DotProduct(vector1, vector2) / (Distance(new RecreateCoordinates(0, 0, 0), vector1) * Distance(new RecreateCoordinates(0,0,0),vector2));


        return Mathf.Acos(dotDivided);
    }


    public static RecreateCoordinates Rotate(RecreateCoordinates vector,float angle,bool clockwise)
    {
        if(clockwise)
        {
            angle = 2 * Mathf.PI - angle; // this method works in radians and 2 * Math.PI is equal to 360 degress of a circle
        }

        float xValue = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);

        float yValue = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);

        return new RecreateCoordinates(xValue, yValue, 0.0f);
    }


    //Craete my own translate
    static public RecreateCoordinates Translate(RecreateCoordinates position,RecreateCoordinates facing ,RecreateCoordinates vector)
    {
        if (RecreateOwnMathematics.Distance(new RecreateCoordinates(0, 0, 0), vector) <= 0)
        {
            return position;
        }

        float angle = RecreateOwnMathematics.Angle(vector,facing);
        float worldAngle = RecreateOwnMathematics.Angle(vector,new RecreateCoordinates(0,1,0));
        bool clockwise = false;

        if (RecreateOwnMathematics.CrossProduct(vector,facing).z < 0)
        {
            clockwise = true;
        }

        vector = RecreateOwnMathematics.Rotate(vector,angle + worldAngle,clockwise);

        float xValue = position.x + vector.x;
        float yValue = position.y + vector.y;
        float zValue = position.z + vector.z;

        return new RecreateCoordinates(xValue,yValue,zValue);
    }


    //translate for matrix
    public static RecreateCoordinates MatrixTranslate(RecreateCoordinates position,RecreateCoordinates vector)
    {
        float[] translateValues =
        {
            1,0,0,vector.x,
            0,1,0,vector.y,
            0,0,1,vector.z,
            0,0,0,1
        };

        Matrix translateMatrix = new Matrix(4, 4, translateValues);

        Matrix pos = new Matrix(4,1,position.AsFloats());

        Matrix result = translateMatrix * pos;
        return result.AsCoordinates();

    }


    public static RecreateCoordinates CrossProduct(RecreateCoordinates vector1,RecreateCoordinates vector2)
    {
        float xCrossValue = vector1.y * vector2.z - vector1.z * vector2.y;
        float yCrossValue = vector1.z * vector2.x - vector1.x * vector2.z;
        float zCrossValue = vector1.x * vector2.y - vector1.y * vector2.x;

        return new RecreateCoordinates(xCrossValue, yCrossValue, zCrossValue);
    }

    //create my own Lerp Behavior
    static public RecreateCoordinates Lerp(RecreateCoordinates A,RecreateCoordinates B,float t)
    {
        t = Mathf.Clamp(t, 0, 1);
        RecreateCoordinates v = new RecreateCoordinates(B.x - A.x,B.y - A.y,B.z - A.z);
        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.z * t;

        return new RecreateCoordinates(xt,yt,zt);
    }

}
