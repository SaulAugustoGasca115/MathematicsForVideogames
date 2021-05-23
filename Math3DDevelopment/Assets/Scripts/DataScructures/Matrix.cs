using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Matrix
{
    float[] values;

    int rows;
    int columns;

    public Matrix(int rows,int columns,float[] v)
    {
        this.rows = rows;
        this.columns = columns;
        values = new float[rows * columns];
        Array.Copy(v,values,rows * columns);
        //this.values = v;
    }

    public RecreateCoordinates AsCoordinates()
    {
        if(rows == 4 && columns == 1)
        {
            return (new RecreateCoordinates(values[0], values[1], values[2], values[3]));
        }
        else
        {
            return null;
        }
    }


    public override string ToString()
    {
        string matrix = "";

        for(int r = 0;r < rows;r++)
        {
            for(int c = 0;c < columns;c++)
            {
                matrix += values[r * columns + c] + " ";
            }

            matrix += "\n";
        }

        return matrix;
    }

    public static Matrix operator +(Matrix a,Matrix b)
    {
        if(a.rows !=  b.rows || a.columns != b.columns)
        {
            return null;
        }

        Matrix result = new Matrix(a.rows,a.columns,a.values);

        int length = a.rows * a.columns;

        for(int i =0;i < length;i++)
        {
            result.values[i] += b.values[i];
        }

        return result;
    }


    public static Matrix operator *(Matrix a,Matrix b)
    {
        if(a.columns != b.rows)
        {
            return null;
        }

        float[] resultValues = new float[a.rows * b.columns];

       for(int i=0;i<a.rows;i++)
        {
            for(int j=0;j<b.columns;j++)
            {
                for(int k=0;k<a.columns;k++)
                {
                    resultValues[i * b.columns + j] += a.values[i * a.columns + k] * b.values[k * b.columns + j];
                }
            }
        }

        Matrix result = new Matrix(a.rows,b.columns,resultValues);


        return result;
    }

}
