using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CameraVisionManager.Instance.UpdateVisionMode(VisionMode.Normal);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CameraVisionManager.Instance.UpdateVisionMode(VisionMode.NightVision);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CameraVisionManager.Instance.UpdateVisionMode(VisionMode.EM);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CameraVisionManager.Instance.UpdateVisionMode(VisionMode.Thermal);
        }
	}
}
