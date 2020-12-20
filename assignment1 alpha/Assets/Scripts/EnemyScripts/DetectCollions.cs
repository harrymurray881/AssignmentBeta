using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollions : MonoBehaviour
{
    private GameManager1 gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Rocket02") 
        {
          
            Destroy(gameObject);
            DestroyObject(other.gameObject);
            gameManager.UpdateScore(1);



        }

    }
}
