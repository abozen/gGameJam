using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    private int backgroundHalfOfHeight;
    private float speed = 2f;
    private float y;
    private float health = 3;
    void Start()
    {
        backgroundHalfOfHeight = (int)(background.GetComponent<Renderer>().bounds.size.y / 2f);
    }

    void Update()
    { 
        y = Mathf.Sin(Time.time * speed) * backgroundHalfOfHeight ;
        
        transform.position = new Vector3(transform.position.x, y + background.GetComponent<Renderer>().bounds.center.y, transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.tag == "Bullet")
        {
            if(health == 3)
            {
                health--;
                Destroy(collision.gameObject);
            }
            else if(health == 2)
            {
                Destroy(collision.gameObject);
                Destroy(heart2);
            }
            else if(health == 1)
            {
                Destroy(heart1);
                Destroy(collision.gameObject);
            }
            else if(health == 0)
            {
                Destroy(heart);
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
        
    }
}
