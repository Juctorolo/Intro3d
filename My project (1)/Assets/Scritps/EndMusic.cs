using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMusic : MonoBehaviour
{
    public GameObject sphere;
    public GameObject audioObject;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.y < 7)
        {
            audioSource.enabled = true;
        }
    }
}
