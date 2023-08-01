using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour
{
    [SerializeField]
    private BoxCollider box;

    private void Start()
    {
        box = GetComponent<BoxCollider>();
    }
    private void Update()
    {
        if(gameObject.transform.parent != null)
        {
            box.enabled = false;
            Debug.Log("disabled");
        }
        else if (gameObject.transform.parent == null)
        {
            box.enabled = true;
            Debug.Log("enabled");
        }
    }
    public void DisableColliderBox()
    {
        box.enabled = false;
        Debug.Log("disabled");
    }

    public void EnableColliderBox()
    {
        box.enabled = true; 
        Debug.Log("enabled");
    }
}
