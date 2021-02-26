using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorinstance : MonoBehaviour
{
    [SerializeField] private Renderer myobject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myobject.material.color = Color.green;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myobject.material.color = Color.red;
        }
    }
}
