using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    private float speed = 30;
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
      
    }

    // Update is called once per frame
    void Update()
       
    {
         transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);

        if (transform.position.x<startPos.x -170)
        {
            transform.position = startPos;
        }

        }
    }

