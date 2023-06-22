using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quibit : MonoBehaviour
{
    public TMP_Text Zero;
    public TMP_Text One;
    public GameObject Area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CarriculumSingleton.Instance.getStep() == 14)
        {
            Zero.color = new Color32(0, 0, 255, 255);
            One.color = new Color32(255, 255, 255, 255);
        } else if
        (CarriculumSingleton.Instance.getStep() == 15)
        {
            Zero.color = new Color32(255, 255, 255, 255);
            One.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            Zero.color = new Color32(255, 255, 255, 255);
            One.color = new Color32(255, 255, 255, 255);
        }

        if (CarriculumSingleton.Instance.getStep() == 17)
        {
            Area.SetActive(true);
        }
    }
}
