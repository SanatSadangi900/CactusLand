using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1 : MonoBehaviour
{
    // Start is called before the first frame update
    private Spin wave;
    public GameObject Free_Racing_Car_Blue;
    public GameObject catusKing2;

    public GameObject catusKing;

    public GameObject catusKing3;

    public GameObject part2;

    public GameObject catus;

    public GameObject button;
    private float x;
    public int xPos;
    private int num;
    private int num2;
    void Start()
    {
        // StartCoroutine(wait());
        StartCoroutine(wave1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(10);
    }

    IEnumerator wave1()
    {
        yield return new WaitForSeconds(4);
        while (num < 3)
        {
            x = Free_Racing_Car_Blue.transform.position.x;
            //transform.Translate(Vector3.forward * Time.deltaTime * -5);
            //xPos = Random.Range(25, 74);
            Instantiate(catusKing2, new Vector3(x, 13.9f, 68), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(8);
            num++;
        }
        while (num2 < 5){
            xPos = Random.Range(27, 84);
            Instantiate(catus, new Vector3(xPos, 19.24f, 68), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(2);
            num2++;
        }
        xPos = Random.Range(27, 84);
        Instantiate(button, new Vector3(xPos, 20f, 68), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player"))
        {
            //xPos = Random.Range(25, 74);
            Destroy(button);
            Destroy(catusKing);
            Instantiate(catusKing3, new Vector3(54.97f, 13.9f, 97.43f), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            Instantiate(part2, new Vector3(0, 19.24f, 68), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            //mainMenu();
        }
    }
}
