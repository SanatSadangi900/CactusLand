using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Flat_Cactus_02;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 56)
        {
            Destroy(Flat_Cactus_02);
        }
    }
}
