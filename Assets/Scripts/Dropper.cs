using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float timeToWait = 5f;
    bool onlyOnce = true;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeToWait && onlyOnce)
        {
            Debug.Log($"5 seconds has passed!"); 
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
            onlyOnce = false;
        }
            
    }
}
