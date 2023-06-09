using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    Rigidbody2D bulletRigidbody;
    [SerializeField] private GameObject player;
    public GameObject bullet;
    public float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            int bulletCount = GetComponent<Player_Controller>().bulletCount;
            if(bulletCount > 0)
            {
                Vector3 position = new Vector3(transform.position.x - 2, transform.position.y, -2);


                GameObject newBullet = Instantiate(bullet, position, Quaternion.Euler(new Vector3(0, 0, 90)));

                player.GetComponent<Animator>().SetBool("isShooting", true);

                bulletRigidbody = newBullet.GetComponent<Rigidbody2D>();

                bulletRigidbody.AddForce(new Vector3(100f * speed, 0f));
                GetComponent<Player_Controller>().bulletCount--;
            }
        }
    }
}
