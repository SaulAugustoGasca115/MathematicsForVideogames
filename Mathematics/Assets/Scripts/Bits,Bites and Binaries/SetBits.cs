using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SetBits : MonoBehaviour
{
    [Header("Bits")]
    public int bitSequence =  8 + 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("<color=green>BIT: " + Convert.ToString(bitSequence,2) + "</color>");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
