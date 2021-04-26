using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [Header("Fly Attributes")]
    public float rotationSpeed = 1.0f;
    public float speed = 1.0f;

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
        float translateX = Input.GetAxis("Horizontal") * speed;
        float translateY = Input.GetAxis("VerticalY") * speed;
        float translateZ = Input.GetAxis("Vertical") * speed;

        //transform.Translate(new Vector3(translateX, 0, 0));
        //transform.Translate(new Vector3(0, translateY, 0));
        //transform.Translate(new Vector3(0, 0, translateZ));

        //transform.Translate(new Vector3(translateX,translateY,translateZ));


        //Recreate Translate
        transform.position = new Vector3(transform.position.x + translateX,transform.position.y + translateY,transform.position.z + translateZ);

    }

    void RotationMovement()
    {
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed;
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed;
        float rotationZ = Input.GetAxis("HorizontalZ") * rotationSpeed;
        float translateZ = Input.GetAxis("VerticalY") * speed;

        transform.Rotate(new Vector3(rotationX,0,0));
        transform.Rotate(new Vector3(0, rotationY , 0));
        transform.Rotate(new Vector3(0, 0, rotationZ));
        transform.Translate(new Vector3(0,0,translateZ));
    }
}
