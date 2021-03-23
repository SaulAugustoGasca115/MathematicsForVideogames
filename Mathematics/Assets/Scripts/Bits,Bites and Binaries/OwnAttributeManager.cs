using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OwnAttributeManager : MonoBehaviour
{

    [Header("UI Elements")]
    public Text attributeDisplay;
    

    [Header("Attributes")]
    static public int MAGIC = 16;
    static public int INTELLIGENCE = 8;
    static public int CHARISMA = 4;
    static public int FLY = 2;
    static public int INVISIBLE = 1;
    public int attributes = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0, -18f, 0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
        attributeDisplay.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MAGIC")
        {
            attributes ^= MAGIC;
        }
        else if(other.gameObject.tag == "INTELLIGENCE")
        {
            attributes |= INTELLIGENCE;
        }
        else if(other.gameObject.tag == "CHARISMA")
        {
            attributes |= CHARISMA;
            //Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "FLY")
        {
            attributes |= FLY;
        }
        else if(other.gameObject.tag == "INVISIBLE")
        {
            attributes |= INVISIBLE;
        }else if(other.gameObject.tag == "ANTIMAGIC")
        {
            attributes &= ~MAGIC;
        }
        else if (other.gameObject.tag == "REMOVE")
        {
            attributes &= ~(INTELLIGENCE | CHARISMA | INVISIBLE | MAGIC );
        }
        else if (other.gameObject.tag == "ADD")
        {
            attributes |= (INVISIBLE);
        }
        else if (other.gameObject.tag == "RESET")
        {
            attributes = 0;
        }

        
    }
}
