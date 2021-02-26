using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColorChange : MonoBehaviour
{
    [SerializeField] private Material Material1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Material1.color = Color.green;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Material1.color = Color.red;
        }
    }
}
