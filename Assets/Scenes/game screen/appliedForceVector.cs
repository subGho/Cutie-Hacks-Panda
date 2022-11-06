using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appliedForceVector : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    void OnMouseDown()
    {
        //GetComponent<Rigidbody>().AddForce(-transform.right * 500);
        //GetComponent<Rigidbody>().useGravity = true;

        GetComponent<Rigidbody2D>().AddForce(-transform.right * 500);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
