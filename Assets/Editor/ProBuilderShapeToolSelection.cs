using System;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.EditorTools;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public static class ProBuilderShapeToolSelection
{
    private static Type _lastTool;
    [Shortcut("ProBuilder/Shape Tool", typeof(SceneView), KeyCode.N)]
    private static void ActivateShapeTool()
    {
        var assembly = GetAssemblyByName("Unity.ProBuilder.Editor");
        var type = assembly.GetType("UnityEditor.ProBuilder.EditShapeTool");

        try
        {
            if (ToolManager.activeToolType != type)
            {
                _lastTool = ToolManager.activeToolType;
                ToolManager.SetActiveTool(type);
            }
            else
            {
                ToolManager.SetActiveTool(_lastTool);
            }
        }
        catch (InvalidOperationException)
        {
        }

    }

    public static Assembly GetAssemblyByName(string name)
    {
        return AppDomain.CurrentDomain
            .GetAssemblies()
            .FirstOrDefault(asm => asm.GetName().Name == name);
    }
}