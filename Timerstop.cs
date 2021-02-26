using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerstop : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("MobileMaleFreeSimpleMovement1").SendMessage("Finish");
    }
}
