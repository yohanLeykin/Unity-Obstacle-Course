using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 1f;
    [SerializeField]float xValue = 0f;
    [SerializeField]float yValue = 0.01f;
    [SerializeField]float zValue = 0f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game! use WASD or the Arrow keys to move around.");
    }

    void MovePlayer()
    {
        //transform.Translate(0.01f,0,0);
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
