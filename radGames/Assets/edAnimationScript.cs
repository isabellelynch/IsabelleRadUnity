using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edAnimationScript : MonoBehaviour
{
    Animator edAnimator;
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        { //make ed walk in animations and move forward
            edAnimator.SetBool("isWalking", true);
            transform.position += speed * transform.forward * Time.deltaTime;
          }
    }
}
