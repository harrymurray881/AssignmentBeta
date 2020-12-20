using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpacebar : MonoBehaviour
{
    public AudioSource missleSound;
    public float timer;
    private float timeLimit = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer > timeLimit)
        {
            missleSound.Play();

            timer = 0;
        }
    }
}
