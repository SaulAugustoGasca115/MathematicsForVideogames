using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    [Header("Matrix Affine Transformation Attributes")]
    public GameObject point;
    public GameObject[] points;
    public Vector3 angle;
    public Vector3 translation;
    public Vector3 scaling;
    public GameObject center;
    Vector3 c;

    // Start is called before the first frame update
    void Start()
    {
         c = new Vector3(center.transform.position.x,center.transform.position.y,center.transform.position.z);
        //RecreateCoordinates position = new RecreateCoordinates(point.transform.position,1);

        //point.transform.position = RecreateOwnMathematics.Translate(position,new RecreateCoordinates(new Vector3(translation.x,translation.y,translation.z),0)).ConvertToVector();

        //MoveArrayPoints();
        RotateArrayPoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveArrayPoints()
    {
        foreach(GameObject p in points)
        {
            

            RecreateCoordinates position = new RecreateCoordinates(p.transform.position,1);

            //p.transform.position = RecreateOwnMathematics.MatrixTranslate(position,new RecreateCoordinates(translation.x,translation.y,translation.z,0)).ConvertToVector();

            position = RecreateOwnMathematics.MatrixTranslate(position, new RecreateCoordinates(new Vector3(-c.x, -c.y, -c.z), 0));

            //p.transform.position = RecreateOwnMathematics.MatrixScale(position,scaling.x,scaling.y,scaling.z).ConvertToVector();

            position = RecreateOwnMathematics.MatrixScale(position, scaling.x, scaling.y, scaling.z);

            p.transform.position = RecreateOwnMathematics.MatrixTranslate(position, new RecreateCoordinates(c.x, c.y, c.z, 0)).ConvertToVector();

        }
    }


    void RotateArrayPoints()
    {
        angle = angle * Mathf.Deg2Rad;

        foreach(GameObject p in points)
        {
            
            RecreateCoordinates position = new RecreateCoordinates(p.transform.position, 1);

            position = RecreateOwnMathematics.MatrixTranslate(position, new RecreateCoordinates(new Vector3(-c.x, -c.y, -c.z), 0));

            //p.transform.position = RecreateOwnMathematics.MatrixRotate(position,angle.x,true,angle.y,true,angle.z,true).ConvertToVector();

            position = RecreateOwnMathematics.MatrixRotate(position, angle.x, true, angle.y, true, angle.z, true);


            p.transform.position = RecreateOwnMathematics.MatrixTranslate(position, new RecreateCoordinates(c.x, c.y, c.z, 0)).ConvertToVector();

        }
    }
}
