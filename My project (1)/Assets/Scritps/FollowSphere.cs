using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSphere : MonoBehaviour
{
    public GameObject sphere;
    private Vector3 offset = new Vector3(0,2,-1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = sphere.transform.position + offset;
    }
}
