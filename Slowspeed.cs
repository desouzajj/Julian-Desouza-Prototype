using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowspeed : MonoBehaviour
{
    [SerializeField] private float slowmoveSpeed = 1.5f;
    [SerializeField] private float moveSpeed = 4.0f;
    public GameObject myPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position += transform.forward * slowmoveSpeed * Time.deltaTime;  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }
}
