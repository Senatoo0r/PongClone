using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 30;
    public Text scorerightText;
    public Text scoreleftText;
  
    int scoreRight;
    int scoreLeft;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.name == "Wallright")
        {
            scoreLeft++;
        
            scoreleftText.text = scoreLeft.ToString();
        }
        if (collision.gameObject.name == "Wallleft")
        {
            scoreRight++;
            scorerightText.text = scoreRight.ToString();
        }
    }
}
