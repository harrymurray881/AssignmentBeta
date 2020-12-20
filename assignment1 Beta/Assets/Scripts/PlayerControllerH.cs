using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerH : MonoBehaviour
{
    public float moveSpeed = 30;
    public ParticleSystem explosionParticle;
    //missle timer
    public float timer;
    private float timeLimit = 1.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        //Keep player inbounds
            if (transform.position.y > 15)
        {
            transform.position = new Vector3(transform.position.x, 15, transform.position.z);
            }
        if (transform.position.y < -17)
        {
            transform.position = new Vector3(transform.position.x, -17, transform.position.z);
        }
        if (transform.position.x < -35)
        {
            transform.position = new Vector3(-35,transform.position.y, transform.position.z);
        }
        if (transform.position.x > 60)
        {
            transform.position = new Vector3(60, transform.position.y, transform.position.z);
        }

        //Helicopter Movement
        //up and down
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        //Left and right
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);

        //timer
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer > timeLimit)
        {
            //fire missile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //reset timer
            timer = 0;
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "enemyH")
            {
                
                explosionParticle.Play();

            }
        }
    }
}