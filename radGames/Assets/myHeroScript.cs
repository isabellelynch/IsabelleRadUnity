using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myHeroScript : MonoBehaviour
{
    float runningSpeed = 3f;
    float turningSpeed = 45f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        { transform.position += runningSpeed*transform.forward * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.S))
        { transform.position -= runningSpeed*transform.forward * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.position += runningSpeed * transform.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= runningSpeed * transform.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += runningSpeed * transform.up * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Backspace))
        {
            transform.position -= runningSpeed * transform.up * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        { transform.Rotate(transform.up, turningSpeed* Time.deltaTime ); 
        }
    }

}
