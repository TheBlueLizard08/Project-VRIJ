using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Footsteps : MonoBehaviour
{
    private AudioSource aS;
    [SerializeField]
    private AudioClip foot1, foot2;
    private bool canStep = true, step1;
    [SerializeField]
    InputActionProperty moveAction;
    private Coroutine stepping;

    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAction.action.phase != InputActionPhase.Waiting && canStep)
        {
            Debug.Log(moveAction.action.phase);
            stepping = StartCoroutine(Step());
        }
    }
    private IEnumerator Step()
    {
        if (step1)
        {
            aS.clip = foot2;
            aS.PlayOneShot(foot2);
            step1 = false;

        }
        else if (!step1)
        {
            aS.clip = foot1;
            aS.PlayOneShot(foot1);
            step1 = true;
        }
        canStep = false;
        yield return new WaitForSecondsRealtime(0.5f);
        canStep = true;
        StopCoroutine(stepping);
    }
}
