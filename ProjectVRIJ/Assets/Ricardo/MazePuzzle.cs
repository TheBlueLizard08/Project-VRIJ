using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazePuzzle : MonoBehaviour
{

    private bool original;
    private GameObject returnPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            other.gameObject.transform.position = returnPos.transform.position;
            other.gameObject.transform.rotation = returnPos.transform.rotation;
        }
    }
}
