using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class EnableLights : MonoBehaviour
{
    [SerializeField]
    private Light[] lights;
    // Start is called before the first frame update
    void Start()
    {
        
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
