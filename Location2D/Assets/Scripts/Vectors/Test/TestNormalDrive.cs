using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNormalDrive : MonoBehaviour
{
    public GameObject prefabObject;
    Vector3 direction;
    public float speed;
    public Vector3 prefabPosition;
    public float stoppingDistance;


    // Start is called before the first frame update
    void Start()
    {
        //prefabPosition = prefabObject.GetComponent<OtherFuelManager>().objectPosition;
        //direction = prefabPosition - this.transform.position;
        ////Debug.Log("DIRECTION: " + direction);
        //TestNormalCoordinates normal =  TestOwnMathematics.GetNormal(new TestNormalCoordinates(direction));
        //direction = normal.ConvertToVector();
        ////Debug.Log("NORMAL DIRECTION" + direction);



        ////float angle = TestOwnMathematics.Angle(new TestNormalCoordinates(0,1,0),new TestNormalCoordinates(direction)) * 180 / Mathf.PI;
        ////Debug.Log("DOT PRODUCT ANGLE: " + angle);

        ////The angle of Cross Product shuld be in radians no in degress
        //float angleToCrossProduct = TestOwnMathematics.Angle(new TestNormalCoordinates(direction),new TestNormalCoordinates(this.transform.up));

        //bool clockwise = false;

        //if(TestOwnMathematics.Cross(new TestNormalCoordinates(this.transform.up),normal).z < 0)
        //{
        //    clockwise = true;
        //}


        //TestNormalCoordinates newRotationDirection = TestOwnMathematics.Rotate(new TestNormalCoordinates(this.transform.up),angleToCrossProduct,clockwise);

        //this.transform.up = new Vector3(newRotationDirection.x, newRotationDirection.y, newRotationDirection.z);


        //***LookAt2D section
        this.transform.up = TestOwnMathematics.LookAt2D(new TestNormalCoordinates(this.transform.up),new TestNormalCoordinates(this.transform.position), new TestNormalCoordinates(prefabObject.GetComponent<OtherFuelManager>().objectPosition)).ConvertToVector();

    }

    // Update is called once per frame
    void Update()
    {
        //MoveToObject();
        MoveToObjectNormal();
    }

    void MoveToObject()
    {
        if(Vector3.Distance(this.transform.position,prefabPosition) > stoppingDistance)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
        
     
    }

    void MoveToObjectNormal()
    {
        if(TestOwnMathematics.Distance(new TestNormalCoordinates(prefabPosition),new TestNormalCoordinates(this.transform.position)) > stoppingDistance)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
    }
}
