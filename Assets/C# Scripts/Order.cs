using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] selectorArr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private bool on1;
    private bool on2;
    private bool on3;
    private int order = 1;
    private static int one = 1;
    private static int two = 2;
    private static int three = 3;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("1"))
        {
            Debug.Log("1");
            if(order == one)
            {
                on1 = true;
                order++;
            } else
            {
                order = 1;
            }
            
        }
        if (collision.gameObject.CompareTag("2"))
        {
            if (order == two)
            {
                on2 = true;
                order++;
            }
            else
            {
                order = 1;
            }
            Debug.Log("2");
        }
        if (collision.gameObject.CompareTag("3"))
        {
            if (order == three)
            {
                on3 = true;
                order++;
            } else
            {
                order = 1;
            }
            Debug.Log("3");
        }
        if (on1 && on2 && on3)
        {
            for (int i = 0; i < selectorArr.Length; i = i + 1)
            {
                Destroy(selectorArr[i]);
                //Debug.Log(selectorArr.Length);
            }
        }
    }
}
