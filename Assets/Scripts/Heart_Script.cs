using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Script : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    private float addNumber;
    // Start is called before the first frame update
    void Start()
    {
        addNumber = 0;
        if(gameObject.tag == "Heart1")
            addNumber = -0.4f;
        else if(gameObject.tag == "Heart2")
            addNumber = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(enemy.transform.position.x + addNumber, enemy.transform.position.y + 1.1f, enemy.transform.position.z);
    }
}
