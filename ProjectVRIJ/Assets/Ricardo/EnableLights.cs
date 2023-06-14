using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class EnableLights : MonoBehaviour
{
    [SerializeField]
    private Light[] lights;
    [SerializeField]
    private GameObject Lever;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Debug.Log(Lever.transform.rotation.x);
        if (Lever.transform.rotation.x >= 0.2)
        {
            Debug.Log("turning on");
            StartCoroutine(LightsOn());
        }
    }
    public void StartLights()
    {
        StartCoroutine(LightsOn());
    }
    //
    //
    //Update is called once per frame

    private IEnumerator LightsOn()
    {
        foreach (Light i in lights)
        {
            i.enabled = true;
            yield return new WaitForSecondsRealtime(0.5f);
        }
      
    }
}
