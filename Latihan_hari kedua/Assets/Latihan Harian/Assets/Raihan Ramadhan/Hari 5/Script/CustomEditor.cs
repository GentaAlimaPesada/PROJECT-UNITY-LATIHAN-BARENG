using UnityEditor;

[CustomEditor(typeof(BuyItem))]
public class BuyItemEditor : Editor
{
    SerializedProperty itemGoldCostProp;
    SerializedProperty itemWoodCostProp;

    void OnEnable()
    {
        // Mengambil referensi SerializedProperty dari variabel BuyItem
        itemGoldCostProp = serializedObject.FindProperty("itemGoldCost");
        itemWoodCostProp = serializedObject.FindProperty("itemWoodCost");
    }

    public override void OnInspectorGUI()
    {
        // Memulai edit serialized object
        serializedObject.Update();

        // Menampilkan field untuk itemGoldCost
        EditorGUILayout.PropertyField(itemGoldCostProp);

        // Menampilkan field untuk itemWoodCost
        EditorGUILayout.PropertyField(itemWoodCostProp);

        // Mengakhiri edit serialized object
        serializedObject.ApplyModifiedProperties();
    }
}
