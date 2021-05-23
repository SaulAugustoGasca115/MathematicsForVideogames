using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawnPlanets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i<=2000;i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = Random.insideUnitSphere * 500.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
