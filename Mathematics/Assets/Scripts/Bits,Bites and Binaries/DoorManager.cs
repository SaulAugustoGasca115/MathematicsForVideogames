using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    [Header("Door")]
    int doorType = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.tag == "BLUE_DOOR")
        {
            doorType = KeyAttributeManager.BLUEKEY;
        }

        if (this.gameObject.tag == "RED_DOOR")
        {
            doorType = KeyAttributeManager.REDKEY;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.GetComponent<KeyAttributeManager>().attributes & doorType) != 0)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<BoxCollider>().isTrigger = false;
        other.gameObject.GetComponent<KeyAttributeManager>().attributes &= ~doorType;
       
    }
}
