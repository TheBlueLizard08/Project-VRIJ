using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    private GameObject lever;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lever")
        {
            lever.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
