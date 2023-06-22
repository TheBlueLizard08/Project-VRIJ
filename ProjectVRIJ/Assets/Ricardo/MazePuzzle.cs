using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazePuzzle : MonoBehaviour
{
    [SerializeField]
    private bool original;
    [SerializeField]
    private GameObject returnPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Player" && !original)
        {
            other.gameObject.transform.position = returnPos.transform.position;
            other.gameObject.transform.rotation = returnPos.transform.rotation;
        }
    }
}
