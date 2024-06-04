using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    int score = 0;
    public float speed;

    Rigidbody rb;

    float xInput;
    float yInput;

    public int winScore;
    public GameObject winText;

  

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame

    void Update()
    {
        if(transform.position.y < -5f)
        {
            SceneManager.LoadScene("Level 1");
        }
    }
    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0, yInput *  speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);

            score++;


            if (score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
