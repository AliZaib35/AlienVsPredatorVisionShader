using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class ThermalEffect : MonoBehaviour
{
    public Shader ReplacementShader;
    void OnEnable()
    {
        if (ReplacementShader != null)
            GetComponent<Camera>().SetReplacementShader(ReplacementShader,null);
    }

    void OnDisable()
    {
        GetComponent<Camera>().ResetReplacementShader();
    }
}