using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
      Debug.Log("Object entered trigger");
    }
    void OnTriggerStay(Collider other)
    {
       Debug.Log("Object is in trigger");
       // Here you add negative forces to object that is within the fan area
       // Other is the object, that should be pushed away
       Vector3 position = transform.position;
       Vector3 targetPosition = other.transform.position;
       Vector3 direction = targetPosition - position;
       direction.Normalize();
       int moveSpeed = 10;
       other.transform.position += direction * moveSpeed * Time.deltaTime;

    }
    void OnTriggerExit(Collider other)
    {
      Debug.Log("Object left the trigger");
    }
}
