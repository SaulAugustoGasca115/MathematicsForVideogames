using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMatrix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float[] mvalues = {1,2,3,4,5,6};
        Matrix m = new Matrix(2,3,mvalues);

        float[] nvalues = { 1, 2, 3, 4, 5,6 };
        Matrix n = new Matrix(3, 2, nvalues);

        Matrix sumAnswer = m + n;

        Matrix multiplicationAnswer = m * n;

        Debug.Log(m.ToString() + "\n" + n.ToString() +  "\n" + multiplicationAnswer.ToString());
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
