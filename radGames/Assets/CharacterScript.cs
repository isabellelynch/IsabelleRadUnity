using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

    public GameObject bulletCloneTemplate;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))


        {
            Instantiate(bulletCloneTemplate, transform.position, transform.rotation);
        }
    }

}
