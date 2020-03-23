// Code is not mine.
// Author: User null, Stackoverflow.
// Source: https://stackoverflow.com/questions/9337700/in-unity3d-is-it-possible-to-keep-the-scene-view-focused-when-hitting-play

using UnityEngine;

public class KeepSceneAlive : MonoBehaviour
{
    public bool KeepSceneViewActive;

    void Start()
    {
        if (this.KeepSceneViewActive && Application.isEditor)
        {
            UnityEditor.SceneView.FocusWindowIfItsOpen(typeof(UnityEditor.SceneView));
        }
    }
}