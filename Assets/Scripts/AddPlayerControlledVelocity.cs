using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{

    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;


    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;
        if(Input.GetKeyDown(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
