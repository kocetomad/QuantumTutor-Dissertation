using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    public GameObject TextBubble;
    public GameObject indicator;

    public GameObject startOverlay;
    public GameObject carriculumButtons;

    public GameObject conventionalComputersModel;
    public GameObject Bit;
    public GameObject Quibit;
    public GameObject Quibit1;
    public GameObject Quibit0;
    public GameObject QuibitSurfece;

    public GameObject Electron;
    public GameObject FrozenElectron;
    public GameObject MicrowaveElectron;

    public GameObject ParaAlgo;

    public GameObject SternG;

    public GameObject BlochRotate;

    GameObject obj;
    GameObject bit;

    GameObject quibit;
    GameObject quibit1;
    GameObject quibit0;
    GameObject quibitSurfece;

    GameObject electron;
    GameObject frozenElectron;
    GameObject microwaveElectron;

    GameObject paraAlgo;

    GameObject sternG;

    GameObject blochRotate;


    private PlacementIndicator placementIndicator;
    void Start()
    {
        placementIndicator = FindAnyObjectByType<PlacementIndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (indicator.activeSelf)
            {
                obj = Instantiate(objectToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);

                GameObject conComputeresModel = Instantiate(conventionalComputersModel, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                bit = Instantiate(Bit, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                
                quibit = Instantiate(Quibit, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                quibit0 = Instantiate(Quibit0, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                quibit1 = Instantiate(Quibit1, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                quibitSurfece = Instantiate(QuibitSurfece, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);

                electron = Instantiate(Electron, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                frozenElectron = Instantiate(FrozenElectron, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                microwaveElectron = Instantiate(MicrowaveElectron, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);

                paraAlgo = Instantiate(ParaAlgo, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), placementIndicator.transform.rotation);
                sternG = Instantiate(SternG, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), SternG.transform.rotation);

                blochRotate = Instantiate(BlochRotate, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y, placementIndicator.transform.position.z), SternG.transform.rotation);

                GameObject bubble = Instantiate(TextBubble, new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y + (float)0.436, placementIndicator.transform.position.z), placementIndicator.transform.rotation);

                sternG.SetActive(false);
                paraAlgo.SetActive(false);
                microwaveElectron.SetActive(false);
                frozenElectron.SetActive(false);
                electron.SetActive(false);
                bit.SetActive(false);
                indicator.SetActive(false);
                startOverlay.SetActive(false);
                carriculumButtons.SetActive(true);
            }

        }
        if (CarriculumSingleton.Instance.getStep() == 3 ||
            CarriculumSingleton.Instance.getStep() == 4 ||
            CarriculumSingleton.Instance.getStep() == 5 ||
            CarriculumSingleton.Instance.getStep() == 7 ||
            CarriculumSingleton.Instance.getStep() == 8 ||
            CarriculumSingleton.Instance.getStep() == 9 ||
            CarriculumSingleton.Instance.getStep() == 12 ||
            CarriculumSingleton.Instance.getStep() == 13 ||
            CarriculumSingleton.Instance.getStep() == 15 ||
            CarriculumSingleton.Instance.getStep() == 16 ||
            CarriculumSingleton.Instance.getStep() == 17 || (CarriculumSingleton.Instance.getStep() > 11 && CarriculumSingleton.Instance.getStep() <= 19) ||
            (CarriculumSingleton.Instance.getStep() >= 52 && CarriculumSingleton.Instance.getStep() < 57)
            )

        {
            obj.SetActive(false);
        }
        else { obj.SetActive(true); }

        if (CarriculumSingleton.Instance.getStep() >= 7 && CarriculumSingleton.Instance.getStep() <= 9)
        {
            bit.SetActive(true);
        }
        else
        {
            bit.SetActive(false);

        }

        if (CarriculumSingleton.Instance.getStep() > 11 && CarriculumSingleton.Instance.getStep() <= 13)
        {
            quibit.SetActive(true);
        }
        else
        {
            quibit.SetActive(false);

        }
        if (CarriculumSingleton.Instance.getStep() == 14)
        {
            quibit0.SetActive(true);
        }
        else
        {
            quibit0.SetActive(false);
        }

        if (CarriculumSingleton.Instance.getStep() >= 15 && CarriculumSingleton.Instance.getStep() <= 16)
        {
            quibit1.SetActive(true);
        }
        else
        {
            quibit1.SetActive(false);
        }

        if (CarriculumSingleton.Instance.getStep() >= 17 && CarriculumSingleton.Instance.getStep() <= 19)
        {
            quibitSurfece.SetActive(true);
        }
        else
        {
            quibitSurfece.SetActive(false);
        }

        if(CarriculumSingleton.Instance.getStep() >= 22 && CarriculumSingleton.Instance.getStep() < 29)
        {
            electron.SetActive(true);
        }
        else
        {
            electron.SetActive(false);
        }

        if (CarriculumSingleton.Instance.getStep() >= 29 && CarriculumSingleton.Instance.getStep() < 33)
        {
            frozenElectron.SetActive(true);
        }
        else
        {
            frozenElectron.SetActive(false);
        }

        if (CarriculumSingleton.Instance.getStep() >= 33 && CarriculumSingleton.Instance.getStep() < 37)
        {
            microwaveElectron.SetActive(true);
        }
        else
        {
            microwaveElectron.SetActive(false);
        }

        if (CarriculumSingleton.Instance.getStep() >= 38 && CarriculumSingleton.Instance.getStep() < 42)
        {
            paraAlgo.SetActive(true);
        }
        else
        {
            paraAlgo.SetActive(false);
        }

        if (CarriculumSingleton.Instance.getStep() >= 45 && CarriculumSingleton.Instance.getStep() < 52)
        {
            sternG.SetActive(true);
        }
        else
        {
            sternG.SetActive(false);
        }
        if (CarriculumSingleton.Instance.getStep() >= 52 && CarriculumSingleton.Instance.getStep() < 57)
        {
            blochRotate.SetActive(true);
        }
        else
        {
            blochRotate.SetActive(false);
        }
    }
}