using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public GameObject Free_Racing_Car_Blue;
    //public GameObject Main_Camera;
    //public Transform Free_Racing_Car_Blue;

    private Vector3 offsets = new Vector3(0, 2, 0);
    private Vector3 offset = new Vector3(0, 90, 0);
    private Vector3 two = new Vector3(90, 0, 0);
    private bool p = false;
    private bool o = false;
    private bool l = true;

    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            p = true;
            o = false;
            l = false;
        }

        if(p)
        {
            transform.position = Free_Racing_Car_Blue.transform.position + offset;
            transform.rotation = Quaternion.Euler(two);
        }

        if (Input.GetKeyDown("b"))
        {
            p = false;
            o = false;
            l = false;
            transform.position = Free_Racing_Car_Blue.transform.position + offset;
            transform.rotation = Quaternion.Euler(two);
        }

        if (Input.GetKeyDown("e"))
        {
            p = false;
            o = true;
            l = false;
            
        }

        if (o)
        {
            transform.position = Free_Racing_Car_Blue.transform.position + offset;
            transform.rotation = Free_Racing_Car_Blue.transform.rotation * Quaternion.Euler(two);
        }

        if (Input.GetKeyDown("n"))
        {
            p = false;
            o = false;
            l = false;
            transform.position = Free_Racing_Car_Blue.transform.position + offset;
            transform.rotation = Free_Racing_Car_Blue.transform.rotation * Quaternion.Euler(two);
        }

        if (Input.GetKeyDown("r"))
        {
            p = false;
            o = false;
            l = true;
        }

        if(l)
        {
            transform.position = Free_Racing_Car_Blue.transform.position + offsets;
            transform.rotation = Free_Racing_Car_Blue.transform.rotation;
        }

        if (Input.GetKeyDown("m"))
        {
            p = false;
            o = false;
            l = false;
            transform.position = Free_Racing_Car_Blue.transform.position + offsets;
            transform.rotation = Free_Racing_Car_Blue.transform.rotation;
        }
    }
    // Update is called once per frame
    /*void Update()
    {   private bool p = false;
        private bool o = false;
        private bool l = true;

        if(Input.GetKeyDown("q"))
        {
            transform.position = Free_Racing_Car_Blue.transform.position + offset;
            transform.rotation = Quaternion.Euler(two);
        }
} 
        }
        
}
        }

        if (Input.GetKeyDown("e"))
        {
            transform.rotation = Free_Racing_Car_Blue.transform.rotation;
            transform.rotation = Free_Racing_Car_Blue.transform.rotation * Quaternion.Euler(two);
        }
        if (Input.GetKeyDown("r"))
        {
            transform.position = Free_Racing_Car_Blue.transform.position + offsets;
            transform.rotation = Free_Racing_Car_Blue.transform.rotation;
        }


        //transform.position = Free_Racing_Car_Blue.transform.position + offset;
        //transform.position = Free_Racing_Car_Blue.transform.position;
        //Main_Camera.transform.position = new Vector3(Free_Racing_Car_Blue.transfrom.position.x, Free_Racing_Car_Blue.transfrom.position.y, transform.position.z);
        //transform.rotation = Free_Racing_Car_Blue.transform.rotation;
        //transform.rotation = Free_Racing_Car_Blue.transform.rotation * Quaternion.Euler(two);
        //transform.rotation = Quaternion.Euler(two);

    }*/
}
