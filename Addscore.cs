using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addscore : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Player")
      //if (other.CompareTag("Player"))
        {
            Score.scoreValue += 100;
        }
    }
}
