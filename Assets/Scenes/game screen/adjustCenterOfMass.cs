using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class adjustCenterOfMass : MonoBehaviour
{
    public Button yourButton;
    public Vector3 com;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);

    }
    //void TaskOnClick()
    //{
    //    Debug.Log("You have clicked the button!");
    //}

        // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("You have clicked the button!");
            com[0] += 100;
            rb.centerOfMass = com;

        }

    }
}
