using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronScript : MonoBehaviour
{
    bool spinning = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spinning)
        {
            transform.Rotate(new Vector3(0f, 0f, 3));
        }

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if(spinning)
            {
                spinning = false;
                if (Random.Range(0, 3) > 1)
                {
                    transform.rotation = new Quaternion(0, 0, 0, 0);
                }
                else
                {
                    transform.rotation = new Quaternion(0, 0, 180, 0);
                }
            }
            else
            {
                spinning = true;
            }
        }
    }
}
