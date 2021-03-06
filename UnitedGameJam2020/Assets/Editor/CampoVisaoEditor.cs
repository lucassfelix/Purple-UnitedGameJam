﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (CampoVisao))]
public class CampoVisaoEditor : Editor
{
    void OnSceneGUI()
    {
        CampoVisao fow = (CampoVisao)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fow.transform.position, Vector3.up, Vector3.forward, 360, fow.viewPlaceholder);
        Vector3 viewAngleA = fow.DirFromAngle(-360 / 2, false);
        Vector3 viewAngleB = fow.DirFromAngle(360 / 2, false);

        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleA * fow.viewPlaceholder);
        Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleB * fow.viewPlaceholder);

    }
    
}
