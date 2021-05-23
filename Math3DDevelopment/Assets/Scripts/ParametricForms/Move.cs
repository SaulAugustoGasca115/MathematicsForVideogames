using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform start;
    public Transform end;
    Line line;
    public float tTime = 0.5f;

    


    // Start is called before the first frame update
    void Start()
    {
        line = new Line(new RecreateCoordinates(start.position),new RecreateCoordinates(end.position),Line.LINETYPE.SEGMENT);
    }

    // Update is called once per frame
    void Update()
    {
        Movement(Time.time * 0.05f);
    }

    void Movement(float time)
    {
        //this.transform.position = line.GetPointAt(time).ConvertToVector();
        this.transform.position = RecreateOwnMathematics.Lerp(new RecreateCoordinates(start.position),new RecreateCoordinates(end.position),time).ConvertToVector();
    }
}
