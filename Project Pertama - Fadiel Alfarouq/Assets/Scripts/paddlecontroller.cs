using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlecontroller : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Vector2 movement = GetInput(); //object get input
        MoveObject(GetInput());   //move object
    }

    private Vector2 GetInput()
    {   
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed; // move up
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;// move down
        }
        
        return Vector2.zero; //move stopped
    }
    private void MoveObject(Vector2 movement)
    {        
        transform.Translate(movement * Time.deltaTime); //move object
    }
}
