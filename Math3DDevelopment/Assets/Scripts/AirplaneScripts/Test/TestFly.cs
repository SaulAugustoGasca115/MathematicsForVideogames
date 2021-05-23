using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFly : MonoBehaviour
{

    public float speed = 10.0f;
    public float rotationSpeed = 70.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FlyMovement();
        RotationMovement();
    }

    void FlyMovement()
    {
        float xTranslate = Input.GetAxis("Horizontal") * speed;
        float yTranslate = Input.GetAxis("VerticalY") * speed;
        float zTranslate = Input.GetAxis("Vertical") * speed;

        transform.position = new Vector3(transform.position.x + xTranslate,transform.position.y + yTranslate,transform.position.z + zTranslate);
    }

    void RotationMovement()
    {
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed;
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed;
        float rotationZ = Input.GetAxis("HorizontalZ") * rotationSpeed;
        float tranlateZ = Input.GetAxis("VerticalY") * speed;

        transform.Rotate(new Vector3(rotationX,0,0));
        transform.Rotate(new Vector3(0,rotationY,0));
        transform.Rotate(new Vector3(0, 0, rotationZ));
        transform.Translate(new Vector3(0,0,tranlateZ));
    }
}
