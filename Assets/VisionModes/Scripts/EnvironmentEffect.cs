﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class EnvironmentEffect : MonoBehaviour
{
    public Shader ReplacementShader;
    public Color OverDrawColor;
    void OnValidate()
    {
        Shader.SetGlobalColor("_OverDrawColor", OverDrawColor);
        
    }

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