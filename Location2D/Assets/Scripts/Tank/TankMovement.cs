using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankMovement : MonoBehaviour
{

    public float speed = 10.0f;
    //public float rotationSpeed = 100.0f;
    public Text energyAmount;
    public Vector3 currentLocation;

    // Start is called before the first frame update
    void Start()
    {
        currentLocation = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    void Movement()
    {
        if (float.Parse(energyAmount.text) <= 0) return;

        //Get Horzintal and Vertical axis
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        //Make it move 10 meter per second instead 10 seconds per frame
        translation *= Time.deltaTime;
        //rotation *= Time.deltaTime;

        // Move translation along the object's -axis
        transform.Translate(0,translation,0);

        //Rotate around our y-axis
        //transform.Rotate(0,0,-rotation);

        energyAmount.text = (float.Parse(energyAmount.text) - Vector3.Distance(currentLocation, this.transform.position)).ToString();

        currentLocation = this.transform.position;
    }
}
