#if UNITY_EDITOR
using UnityEditor;
using System.Linq;
using Tugas5;

[CustomEditor(typeof(PlayerController), true)]
public class PlayerControllerEditor : Editor 
{
    SerializedProperty[] properties;
    bool showAtributs, showLocations = false;

    void OnEnable() 
    {
        properties = new SerializedProperty[] {
            serializedObject.FindProperty("moveSpeed"),
            serializedObject.FindProperty("movePoint"),
            serializedObject.FindProperty("whatStopsMovement"), 
            serializedObject.FindProperty("playerState"), 
        };
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        DrawFoldout(ref showAtributs, "Attribute", properties.Skip(0).Take(1).ToArray());
        DrawFoldout(ref showLocations, "Locations", properties.Skip(1).Take(3).ToArray());

        serializedObject.ApplyModifiedProperties();
    }

    void DrawFoldout(ref bool show, string label, params SerializedProperty[] properties)
    {
        show = EditorGUILayout.BeginFoldoutHeaderGroup(show, label);
        if (show)
        {
            foreach (SerializedProperty property in properties)
            {
                EditorGUILayout.PropertyField(property);
            }
        }
        EditorGUILayout.EndFoldoutHeaderGroup();
    }
}

#endif