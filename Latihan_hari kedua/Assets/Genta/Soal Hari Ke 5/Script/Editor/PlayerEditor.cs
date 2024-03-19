using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(Player))]
public class PlayerEditor : Editor
{
    SerializedProperty position;
    SerializedProperty speed;
    SerializedProperty health;
    SerializedProperty coins;

    bool playerSpeedGroup = false;

    private void OnEnable()
    {
        position = serializedObject.FindProperty("position");
        speed = serializedObject.FindProperty("speed");
        health = serializedObject.FindProperty("health");
        coins = serializedObject.FindProperty("coins");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        playerSpeedGroup = EditorGUILayout.BeginFoldoutHeaderGroup(playerSpeedGroup, "Data Player");
        if (playerSpeedGroup )
        {
            EditorGUILayout.PropertyField(position);
            EditorGUILayout.PropertyField(speed);
            EditorGUILayout.PropertyField(health);
            EditorGUILayout.PropertyField(coins);
        }

        

        serializedObject.ApplyModifiedProperties();
    }
}
