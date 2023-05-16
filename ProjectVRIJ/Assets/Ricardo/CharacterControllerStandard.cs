using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterControllerStandard : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody rb;
    private float camRotate;
    [SerializeField]
    private GameObject mainCam;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Vertical"));
        if (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical") == -1)
        {
            transform.Translate(mainCam.transform.forward * (Input.GetAxis("Vertical") * speed));
        }
        if (Input.GetAxis("Horizontal") == 1 || Input.GetAxis("Horizontal") == -1)
        {
            transform.Translate(mainCam.transform.right * (Input.GetAxis("Horizontal") * speed));
        }

        camRotate = Input.GetAxis("Mouse Y") * 5;
        Debug.Log(-camRotate);
        mainCam.transform.Rotate(new Vector3(-camRotate, 0));
        gameObject.transform.Rotate(0, Input.GetAxis("Mouse X") * 5, 0);


    }
}
