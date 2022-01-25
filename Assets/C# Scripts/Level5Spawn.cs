using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] selectorArrs = new GameObject[4];
    void Start()
    {
        StartCoroutine(SpawnIt());
    }

    // Update is called once per frame
    IEnumerator SpawnIt()
    {
        while (true)
        {
            Instantiate(selectorArrs[0], new Vector3(55.27f, 0, 19.02f), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(0.1f);
            Instantiate(selectorArrs[1], new Vector3(49.59f, 0, 18.98f), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(0.1f);
            Instantiate(selectorArrs[2], new Vector3(44.19f, 0, 19.09f), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(0.1f);
            Instantiate(selectorArrs[3], new Vector3(37.86f, 0, 19), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(3.5f);
        }
    }
}
