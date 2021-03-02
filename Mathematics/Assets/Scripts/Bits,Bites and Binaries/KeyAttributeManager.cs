using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class KeyAttributeManager : MonoBehaviour
{

    [Header("Key Mask")]
    static public int BLUEKEY = 8;
    static public int REDKEY = 3;

    [Header("General Attributes")]
    public Text binaryText;
    public int attributes = 0;

    

    public GameObject[] ori;
    // Start is called before the first frame update
    void Start()
    {
        //ori = GameObject.FindGameObjectWithTag("RED_KEY");
        for(int i =0;i<ori.Length;i++)
        {
            if(ori.Length == 0)
            {
                ori[i] = GameObject.FindGameObjectWithTag("RED_KEY");
                //ori[i].SetActive(true);
            }

            if(ori.Length == 1)
            {
                ori[i] = GameObject.FindGameObjectWithTag("BLUE_KEY");
            }

            if (ori.Length == 2)
            {
                ori[i] = GameObject.FindGameObjectWithTag("GOLDEN_KEY");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        binaryText.transform.position = screenPoint + new Vector3(0, -18f, 0);
        binaryText.text = Convert.ToString(attributes, 2).PadLeft(8,'0');
        binaryText.color = Color.white;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BLUE_KEY")
        {
            attributes |= BLUEKEY;
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);

        }
        else if(other.gameObject.tag == "RED_KEY")
        {
            attributes |= REDKEY;
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
        }
        else if(other.gameObject.tag == "GOLDEN_KEY")
        {
            attributes |= (REDKEY | BLUEKEY);
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);

        }
        else if(other.gameObject.tag == "RESET_KEY")
        {
            attributes &= ~(REDKEY | BLUEKEY);


            //gameObject.SetActive(true);


            ori[0].SetActive(true);
            ori[1].SetActive(true);
            ori[2].SetActive(true);



            //Instantiate(this.gameObject.CompareTag("RESET_KEY"),transform.position, transform.rotation);

            //for (int i = 0; i < ori.Length; i++)
            //{
            //    if (ori.Length == 0)
            //    {
            //        //ori[i] = GameObject.FindGameObjectWithTag("RED_KEY");



            //    }
            //}




        }
    }
}
