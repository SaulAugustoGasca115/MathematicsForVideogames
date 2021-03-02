using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    [Header("Key")]
    int keyType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(2,0,0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "ADD")
        //{
        //    keyType |= OwnAttributeManager.
        //}
    }
}
