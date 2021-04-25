using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Camera Attributes")]
    public Transform player;
    public RectTransform panel;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.position.x,player.position.y,this.transform.position.z);
        //this.transform.position = new Vector3(panel.position.x,panel.position.y,this.transform.position.z);
    }
}
