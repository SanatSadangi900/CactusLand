using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeSpawn : MonoBehaviour
{
    public GameObject r;
    public int xPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnIt());
    }

    // Update is called once per frame
    IEnumerator spawnIt()
    {
        while (true)
        {
            xPos = Random.Range(25, 74);
            Instantiate(r, new Vector3(xPos, 0, 68), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            yield return new WaitForSeconds(1f);
        }
    }
}
