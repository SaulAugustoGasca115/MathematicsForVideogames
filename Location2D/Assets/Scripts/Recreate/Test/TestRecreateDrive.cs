using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRecreateDrive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 5.0f;
    public GameObject fuelManager;
    Vector3 direction;
    public float stoppingDistance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //direction = fuelManager.transform.position - this.transform.position;

        //RecreateCoordinates normal = TestRecreateMathemathics.NormalVector(new RecreateCoordinates(direction));
        //direction = normal.ConvertToVector();

        //float angle = TestRecreateMathemathics.Angle(new RecreateCoordinates(this.transform.up), new RecreateCoordinates(direction));

        //bool clockwise = false;

        //if(TestRecreateMathemathics.CrossProduct(new RecreateCoordinates(this.transform.up),normal).z < 0)
        //{
        //    clockwise = true;
        //}

        //RecreateCoordinates newRotationDirection = TestRecreateMathemathics.Rotate(new RecreateCoordinates(this.transform.up),angle,clockwise);
        //transform.up = new Vector3(newRotationDirection.x,newRotationDirection.y,newRotationDirection.z);

        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement();
        //TranslateMovement();
        //MoveToTarget();
        TranslateMovement();
    }

    void Movement()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(new Vector3(0.0f,translation,0.0f));
        transform.Rotate(new Vector3(0,0,-rotation));
    }

    void TranslateMovement()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.position = RecreateOwnMathematics.Translate(new RecreateCoordinates(transform.position),new RecreateCoordinates(transform.up),new RecreateCoordinates(0,translation,0)).ConvertToVector();

        transform.up = RecreateOwnMathematics.Rotate(new RecreateCoordinates(this.transform.up),rotation * 180.0f / Mathf.PI,true).ConvertToVector();
    }

    void MoveToTarget()
    {
        if(RecreateOwnMathematics.Distance(new RecreateCoordinates(this.transform.position),new RecreateCoordinates(fuelManager.transform.position)) > stoppingDistance)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
        
    }
}
