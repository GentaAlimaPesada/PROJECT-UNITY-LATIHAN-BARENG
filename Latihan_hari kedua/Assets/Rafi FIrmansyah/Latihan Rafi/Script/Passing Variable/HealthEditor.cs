#if UNITY_EDITOR
using System.Collections;
using UnityEditor;
using System.Linq;


[CustomEditor(typeof(Health), true)]
public class HealthEditor : Editor
{
    SerializedProperty[] properties;
    bool showAtributs, showPanelUI = false;

    // Start is called before the first frame update
    void OnEnable()
    {
        properties = new SerializedProperty[]
        {
            serializedObject.FindProperty("maxHealth"),
            serializedObject.FindProperty("currentHealth"),
            serializedObject.FindProperty("deathPanel"),
            serializedObject.FindProperty("healthBarFill")
        };
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        DrawFoldout(ref showAtributs, "Health Parameter", properties.Skip(0).Take(2).ToArray());
        DrawFoldout(ref showPanelUI, "UI Parameter", properties.Skip(2).Take(4).ToArray());

    }

    void DrawFoldout(ref bool show , string label , params SerializedProperty[] properties)
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