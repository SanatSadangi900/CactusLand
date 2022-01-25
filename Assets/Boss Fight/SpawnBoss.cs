using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject catusKing;

    public GameObject part1;

    public GameObject itself;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(catusKing, new Vector3(54.97f, 13.9f, 97.43f), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
        //Instantiate(part1, new Vector3(0f, 3f, 0f), Quaternion.Euler(new Vector3(50, -30, 0))/*Quaternion.identity*/);
        Destroy(itself);
    }
}
