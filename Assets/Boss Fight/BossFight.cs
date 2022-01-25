using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject catusKing;
    public GameObject catusKing2;
    public GameObject Free_Racing_Car_Blue;
    public bool Wave1 = false;

    private float x;
    void Start()
    {
        // StartCoroutine(spin());
        // //x = catusKing.transform.position.x;
        // if(Wave1){
        //     StartCoroutine(wave1());
        // }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     StartCoroutine(spin());
    //     //x = catusKing.transform.position.x;
    //     if(Wave1){
    //         StartCoroutine(wave1());
    //     }
    // }

    // IEnumerator spin(){
    //     for(int i = 0; i < 361; i++){
    //         Debug.Log(i);
    //         catusKing.transform.rotation = Quaternion.Euler(0, i, 0);
    //         yield return new WaitForSeconds(0.0f);
    //     }
    //     //Wave1 = true;
    //     Debug.Log(Wave1);
    // }

    // private void wave1(){
    //     for(int i = 0; i < 3; i++){
    //         x = Free_Racing_Car_Blue.transform.position.x;
    //         transform.Translate(Vector3.forward * Time.deltaTime * -5);
    //         if(x < 13){
    //             x = 97;
    //         }
    //     }
    // }

    IEnumerator wave1()
    {
        while (true)
        {
            x = Free_Racing_Car_Blue.transform.position.x;
            //transform.Translate(Vector3.forward * Time.deltaTime * -5);
            //xPos = Random.Range(25, 74);
            Instantiate(catusKing2, new Vector3(x, 13.9f, 68), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(100000000);
        }
    }
    
}
