using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float turnspeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, turnspeed * Time.deltaTime); 
    }
}
