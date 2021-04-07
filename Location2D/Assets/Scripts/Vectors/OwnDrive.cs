using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnDrive : MonoBehaviour
{

    public float speed = 0.01f;
    public GameObject fuelManager;
    Vector3 direction;
    public float stoppingDistance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //fuel.GetComponent<OtherFuelManager>().objectPosition; 
        direction = fuelManager.GetComponent<OtherFuelManager>().objectPosition - this.transform.position;

        //normal vector section
        NormalCoordinates directionNormal = HolisticMath.GetNormal(new NormalCoordinates(direction));
        direction = directionNormal.ToVector();

        float angle = HolisticMath.Angle(new NormalCoordinates(0,1,0),new NormalCoordinates(direction)) *  180.0f / Mathf.PI; //ANGLE RADIANS TO DEGRESS
        Debug.Log("Angle from Tank to Fuel: " + angle);
    }

    // Update is called once per frame
    void Update()
    {
        MoveToObject();
    }

    void MoveToObject()
    {
        //this.transform.position = fuel.transform.position;

         

        //this.transform.position = fuelManager.GetComponent<OtherFuelManager>().objectPosition;
        //if(Vector3.Distance(this.transform.position,fuelManager.GetComponent<OtherFuelManager>().objectPosition) > stoppingDistance)
        //{
        //    this.transform.position += direction * speed;
        //}

        //Normal section
        if(HolisticMath.GetDistance(new NormalCoordinates(this.transform.position),new NormalCoordinates(fuelManager.GetComponent<OtherFuelManager>().objectPosition)) > stoppingDistance)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
        
       
    }
}
