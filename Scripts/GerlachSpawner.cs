using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerlachSpawner : MonoBehaviour
{
    public GameObject Electron;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Instantiate(Electron, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
        }
    }
}
