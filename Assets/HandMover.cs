using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMover : MonoBehaviour
{

    public GameObject bigHand;
    public GameObject smallHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bigHand.transform.Rotate(0,12*Time.deltaTime, 0); 
        smallHand.transform.Rotate(0,-Time.deltaTime, 0); 
    }
}
