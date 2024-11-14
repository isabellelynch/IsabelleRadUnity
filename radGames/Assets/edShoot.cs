using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edShoot : MonoBehaviour
{

    public GameObject bulletCloneTemplate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))


        {
            Instantiate(bulletCloneTemplate, transform.position, transform.rotation);
        }
    }
}
