using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecreateDrive : MonoBehaviour
{

    [Header("Recreate Drive")]
    public float speed = 15.0f;
    public float rotationSpeed = 5.0f;

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

        //transform.Translate(new Vector3(0, translation, 0));
        //transform.Rotate(new Vector3(0,0,-rotation));

        transform.position = RecreateOwnMathematics.Translate(new RecreateCoordinates(transform.position),new RecreateCoordinates(transform.up),new RecreateCoordinates(0,translation,0)).ConvertToVector();

        //My Own Movement drived my own mathematics normal,dot product, angle , rotate and cross product
        transform.up = RecreateOwnMathematics.Rotate(new RecreateCoordinates(transform.up), rotation * Mathf.PI / 180, true).ConvertToVector();
    }
}
