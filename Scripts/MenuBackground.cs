using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {


        if (transform.localPosition.y < -2768)
        {
            Debug.Log("in");
            transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x, -590, transform.localPosition.z), transform.localRotation);

        }
        else
        {
            transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x, transform.localPosition.y - (float)0.5, transform.localPosition.z), transform.localRotation);
        }
    }
}
