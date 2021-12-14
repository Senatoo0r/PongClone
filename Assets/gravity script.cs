using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityScript : MonoBehaviour
{
    float gravity = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gravity=Input.GetAxis("Vertical");
      
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}

