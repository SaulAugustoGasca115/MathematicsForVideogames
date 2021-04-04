using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestTankMovement : MonoBehaviour
{
    public float speed = 16.0f;
    public float rotationSpeed = 100.0f;
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

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;


        transform.Translate(new Vector3(0,translation,0));

        transform.Rotate(new Vector3(0,0,-rotation));

        energyAmount.text = (float.Parse(energyAmount.text) - Vector3.Distance(currentLocation, this.transform.position)).ToString();

        currentLocation = this.transform.position;
    }
}
