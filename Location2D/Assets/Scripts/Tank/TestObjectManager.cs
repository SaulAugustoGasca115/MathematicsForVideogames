using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjectManager : MonoBehaviour
{

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateObject(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateObject(GameObject obj)
    {
        GameObject prefabObj = Instantiate(obj,new Vector3(Random.Range(-160,160),Random.Range(-100,100),obj.transform.position.z),Quaternion.identity);

        Debug.Log("POSITION: " + prefabObj.transform.position);

    }
}
