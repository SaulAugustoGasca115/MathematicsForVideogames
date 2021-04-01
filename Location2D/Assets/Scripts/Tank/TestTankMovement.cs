using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTankMovement : MonoBehaviour
{
    public float speed = 16.0f;
    public float rotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;


        transform.Translate(new Vector3(0,translation,0));

        transform.Rotate(new Vector3(0,0,-rotation));
    }
}
