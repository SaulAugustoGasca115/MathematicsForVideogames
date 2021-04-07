using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherFuelManager : MonoBehaviour
{
    public GameObject fuelPrefab;
    public Vector3 objectPosition;


    // Start is called before the first frame update
    void Awake()
    {
        SetFuelPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetFuelPrefab()
    {
        GameObject pos = Instantiate(fuelPrefab,new Vector3(Random.Range(-50, 50), Random.Range(-30, 30), this.transform.position.z),Quaternion.identity);


        objectPosition = pos.transform.position;

    }
}
