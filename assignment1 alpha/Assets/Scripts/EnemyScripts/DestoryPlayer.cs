using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlayer : MonoBehaviour
{
    public ParticleSystem explosionParticle;
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
        if (other.gameObject.tag == "enemyH")
        {
            Destroy(gameObject);
            DestroyObject(other.gameObject);
            gameManager.GameOver();
            explosionParticle.Play();

        }
    }
}
