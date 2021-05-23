using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphereMatrix : MonoBehaviour
{

    public float Speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveSphere();
    }

    void MoveSphere()
    {
        float translation = Input.GetAxis("Vertical") * Speed;
        float horizontal = Input.GetAxis("Horizontal") * Speed;

        translation *= Time.deltaTime;
        horizontal *= Time.deltaTime;

        //transform.Translate(new Vector3(0,0,translation));

        this.transform.position = RecreateOwnMathematics.MatrixTranslate(new RecreateCoordinates(this.transform.position,1),new RecreateCoordinates(horizontal,0,translation,1)).ConvertToVector();

        //transform.position = RecreateOwnMathematics.Translate(new RecreateCoordinates(transform.position),new RecreateCoordinates(transform.forward),new RecreateCoordinates(0,0,translation)).ConvertToVector();
    }
}
