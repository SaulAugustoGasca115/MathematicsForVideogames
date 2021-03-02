using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [Header("Camera Follow")]
    public Transform player;
    public float distance = 10;
    public float height = 5;
    public Vector3 lookOffset = new Vector3(0, 1, 0);
    public float cameraSpeed = 100f;
    public float rotationSpeed = 100f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(player)
        {
            Vector3 lookPosition = player.position + lookOffset;
            Vector3 relativePosition = lookPosition - transform.position;

            Quaternion rotation = Quaternion.LookRotation(relativePosition);

            transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, Time.deltaTime * rotationSpeed * 0.1f);

            Vector3 targetPosition = player.position + player.up * height - player.forward * distance;

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, Time.deltaTime * cameraSpeed * 0.1f);

        }
    }
}
