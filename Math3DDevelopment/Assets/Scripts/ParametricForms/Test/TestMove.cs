using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public Transform start;
    public Transform end;
    TestLine line;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        //line = new TestLine(new RecreateCoordinates(start.position),new RecreateCoordinates(end.position),TestLine.LINETYPE.SEGMENT);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = line.GetPointAt(t).ConvertToVector();
        //this.transform.position = line.Lerp(Time.time * t).ConvertToVector();
        this.transform.position = RecreateOwnMathematics.Lerp(new RecreateCoordinates(start.position),new RecreateCoordinates(end.position),Time.time * t).ConvertToVector();
    }
}
