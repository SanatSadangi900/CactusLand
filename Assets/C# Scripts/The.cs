using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class The : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Flat_Cactus_02;
    public GameObject bone;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public int one = 1;
    void Start()
    {
        StartCoroutine(spawnIt());
    }

    IEnumerator spawnIt()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(20, 76);
            zPos = Random.Range(18, 76);
            Instantiate(Flat_Cactus_02, new Vector3(xPos, 0, zPos), Quaternion.Euler(new Vector3(0, 90, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(0.0f);
            enemyCount += 1;
        }
        while (one < 2)
        {
            xPos = Random.Range(20, 76);
            zPos = Random.Range(18, 76);
            Instantiate(bone, new Vector3(xPos, 0, zPos), Quaternion.Euler(new Vector3(0, -90, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(0.0f);
            one += 1;
        }
    }
}
