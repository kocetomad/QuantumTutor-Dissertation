using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    public MeshRenderer One;
    public MeshRenderer Zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CarriculumSingleton.Instance.getStep() == 9)
        {
            Zero.enabled = false;
            One.enabled = true;
        }
 
    }
}
