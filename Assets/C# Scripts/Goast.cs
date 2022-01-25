using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goast : MonoBehaviour
{

    public KeyCode rat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(2, 0, 0);

        if(Input.GetKeyDown (rat))
        {
            //GetComponent<Rigidbody>().gravityScale = 0;
            GetComponent<BoxCollider>().isTrigger = true;
            //GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            GetComponent<BoxCollider>().isTrigger = true;
        } else
        {
            GetComponent<BoxCollider>().isTrigger = false;
        }

    }
}
