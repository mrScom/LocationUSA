using UnityEditor;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.ProBuilder;


public static class TogglePivotRotation
{
    [MenuItem("Tools/Toggle Pivot Rotation _b")]
    private static void TogglePivotMode()
    {
        Tools.pivotRotation = Tools.pivotRotation == PivotRotation.Global
            ? PivotRotation.Local
            : PivotRotation.Global;

        Debug.Log("Pivot mode: " + Tools.pivotRotation);
        SceneView.RepaintAll();
    }
}