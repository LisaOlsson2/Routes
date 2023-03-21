using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
public abstract class CustomClasses: MonoBehaviour
{
#if UNITY_EDITOR

    [MenuItem("Assets/Create/CustomClass/LightOrShadowTile")]
    public static void CreateClass()
    {
        Create("LightAndShadowTiles");
    }

    public static void Create(string s)
    {
        string path = EditorUtility.SaveFilePanelInProject("Save " + s, "New " + s, "Asset", "Save " + s, "Assets");
        if (path == "")
        {
            return;
        }

        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance(s), path);
    }


#endif
}
