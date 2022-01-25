using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryButton : MonoBehaviour
{
    public GameObject[] selectorArr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < selectorArr.Length; i = i + 1)
            {
                Destroy(selectorArr[i]);
                //Debug.Log(selectorArr.Length);
            }
            /*Destroy(selectorArr[0]);
            Destroy(selectorArr[1]);
            Destroy(selectorArr[2]);
            Destroy(selectorArr[3]);
            Destroy(selectorArr[4]);
            Destroy(selectorArr[5]);
            Destroy(selectorArr[6]);
            Destroy(selectorArr[7]);*/
        }
    }
}
