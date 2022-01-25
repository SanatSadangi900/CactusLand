using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    //public bool startBoss = true;
    void Start()
    {
        StartCoroutine(spin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spin(){
        for(int i = 0; i < 361; i++){
            Debug.Log(i);
            transform.rotation = Quaternion.Euler(0, i, 0);
            //startBoss = true;
            yield return new WaitForSeconds(0.0f);
        }
    }
}
