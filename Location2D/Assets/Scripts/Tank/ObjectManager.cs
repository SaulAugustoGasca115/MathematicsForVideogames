using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{

    public GameObject objectPrefab;
    public Vector3 objectPosition;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = Instantiate(objectPrefab, new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), objectPrefab.transform.position.z), Quaternion.identity);

        Debug.Log("<color=blue> Fuel Location: " + obj.transform.position + "</color>");

        objectPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
