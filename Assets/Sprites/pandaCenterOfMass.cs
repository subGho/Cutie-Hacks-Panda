using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExampleClass : MonoBehaviour
{
    public Button yourButton;
    public Vector3 com;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
        Button btn = yourButton.GetComponent<Button>();
		    btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}
}
