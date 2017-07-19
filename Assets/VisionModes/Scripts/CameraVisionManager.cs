using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraVisionManager : MonoBehaviour {

    [SerializeField]
    private VisionMode CurrentVisionMode ;

    [SerializeField]
    private List<GameObject> visionObjects;
    public static CameraVisionManager Instance;

    void init()
    {
        visionObjects.ForEach(x => x.SetActive(false));
        visionObjects[(int)CurrentVisionMode].SetActive(true);
    }
	// Use this for initialization
	void Start () {
        init();
        Instance = this;
	}

    public void UpdateVisionMode(VisionMode mode)
    {
        if (mode == CurrentVisionMode)
            return ;
        visionObjects[(int)CurrentVisionMode].SetActive(false);
        CurrentVisionMode = mode;
        visionObjects[(int)CurrentVisionMode].SetActive(true);
    }
	
}
public enum VisionMode
{
    Normal=0,
    NightVision,
    EM,
    Thermal
}
