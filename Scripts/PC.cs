using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
	public MeshRenderer rend;
	// Start is called before the first frame update
	public enum RotationAxis
	{
		All,
		Y,
		X,
		Z
	}

	public RotationAxis axis;
	public float speedRot = 0.3f;

	void Update()
	{
		transform.Rotate(new Vector3(0f, 1, 0f));

		if (CarriculumSingleton.Instance.getStep() == 3)
        {
			rend.enabled = true;
        }
		else
		{
			rend.enabled = false;
		}

	}
}

