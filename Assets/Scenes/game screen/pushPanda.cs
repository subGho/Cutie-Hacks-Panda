using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushPanda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.mousePosition[0] < 845) && Input.GetMouseButtonDown(0))
        {
            Debug.Log("CLICKED ON LEFT");
            GetComponent<Rigidbody2D>().AddForce(transform.right * 5000);
        }
        else if ((Input.mousePosition[0] > 845) && Input.GetMouseButtonDown(0))
        {
            Debug.Log(" CLICKED ON RIGHT");
            GetComponent<Rigidbody2D>().AddForce(-transform.right * 5000);
        }
        //Debug.Log(Input.mousePosition);
    }
}
// less than 845 x coordinate is on the left side
// more than 845 x coordinatre is on the right side