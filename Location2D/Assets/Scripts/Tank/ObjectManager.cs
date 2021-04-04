using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{

    public GameObject objectPrefab;

    public GameObject player;

    public Text energyText;

    //UIManager manager;

    public Vector3 objectPosition;
    public int power;
    public int value;
    public int v;

    GameObject ins;

    //string up;

    UIManager m = new UIManager();



    // Start is called before the first frame update
    void Awake()
    {
        GameObject obj = Instantiate(objectPrefab, new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), objectPrefab.transform.position.z), Quaternion.identity);

        Debug.Log("<color=blue> Fuel Location: " + obj.transform.position + "</color>");

        objectPosition = obj.transform.position;

       

        // v = manager.GetComponent<UIManager>().n;

        //player.GetComponent<TankMovement>();


        //if (manager != null)
        //{
        //    value = manager.GetComponent<UIManager>().n;
        //    //manager.energyAmount.text = energyText.text;
        //    //manager.GetComponent<UIManager>();
        //    //manager.GetComponent<UIManager>().n = power;\
        //    //manager.n += 50;


        //}


        //value = 50;

        //UIManager manager;

        //manager.n += 50;

        //if(manager != null)
        //{
        //    manager.GetComponent<UIManager>();

        //    manager.setN(50);
        //}


        //power += 50;


        //if (manager != null)
        //{
        //    manager.setN(50);
        //}

        //ins = new GameObject();
        //UIManager manager = ins.AddComponent<UIManager>();
        //manager.setN(50);

    }

    // Update is called once per frame
    void Update()
    {
       

        //Debug.Log(m.GetValue());
        CalculateDistance();
    }

    public void CalculateDistance()
    {
        float distance = Vector3.Distance(objectPosition,player.transform.position);

        if(distance <= 1.0f)
        {
            //energyText.text += power.ToString();
            //manager.n += power;
            //power = power;
            //power = 50;
            //Debug.Log("REFUELLLLLLLL");

            m.OtherValue = 50;

            Debug.Log(m.GetValue());

        }

        
    }
}
