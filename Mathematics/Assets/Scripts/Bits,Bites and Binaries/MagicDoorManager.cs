using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicDoorManager : MonoBehaviour
{
    int doorType = OwnAttributeManager.MAGIC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.GetComponent<OwnAttributeManager>().attributes & doorType) != 0)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    //private void OnCollisionExit(Collider other)
    //{

    //    this.GetComponent<BoxCollider>().isTrigger = false;
    //    other.gameObject.GetComponent<OwnAttributeManager>().attributes &= 0;
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    this.GetComponent<BoxCollider>().isTrigger = false;
    //}

    private void OnTriggerExit(Collider other)
    {

        this.GetComponent<BoxCollider>().isTrigger = false;
        other.gameObject.GetComponent<OwnAttributeManager>().attributes &= ~OwnAttributeManager.MAGIC;
    }
}
