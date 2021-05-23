using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    public GameObject point;
    public GameObject[] points;
    public float angle;
    public Vector3 translation;

    // Start is called before the first frame update
    void Start()
    {
        //RecreateCoordinates position = new RecreateCoordinates(point.transform.position,1);

        //point.transform.position = RecreateOwnMathematics.Translate(position,new RecreateCoordinates(new Vector3(translation.x,translation.y,translation.z),0)).ConvertToVector();

        MoveArrayPoints();
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

            p.transform.position = RecreateOwnMathematics.MatrixTranslate(position,new RecreateCoordinates(translation.x,translation.y,translation.z,0)).ConvertToVector();

        }
    }
}
