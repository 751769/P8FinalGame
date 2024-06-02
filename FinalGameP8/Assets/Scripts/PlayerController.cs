using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            MoveForward();
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            MoveBackward();
        }
    }

    void MoveForward()
    {
        Vector3 movement = Vector3.left * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    void MoveBackward()
    {
        Vector3 movement = Vector3.right * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
