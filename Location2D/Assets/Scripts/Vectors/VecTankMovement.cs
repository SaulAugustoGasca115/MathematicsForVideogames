using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VecTankMovement : MonoBehaviour
{

    [Header("Vector Tank Movement")]
    public float speed = 15;
    public float rotationSpeed = 100.0f;
    Vector2 direction = new Vector2(-0.1f, -0.1f);

    Vector2 rightDirection = new Vector2(0.1f,0);
    Vector2 leftDirection = new Vector2(-0.1f,0);

    public float vectorSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement();
        Vector3DPosition();
       
      
    }

    void Movement()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;


        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0,translation,0);

        transform.Rotate(new Vector3(0,0,-rotation));
    }

    void Vector3DPosition()
    {
        Vector3 position = this.transform.position;
        //position.x += 0.1f;
        //position.y += 0.1f;
        //position.x += direction.x;
        //position.y += direction.y;

        //this.transform.position = position;


        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.x += 0.0f * vectorSpeed;
            position.y += 0.1f *  vectorSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y += -0.1f * vectorSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += rightDirection.x * vectorSpeed;
            position.y += rightDirection.y * vectorSpeed;

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x += leftDirection.x * vectorSpeed;
            position.y += leftDirection.y * vectorSpeed;
        }

        this.transform.position = position;
    }
}
