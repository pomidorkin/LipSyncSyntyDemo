using UnityEditor;

namespace UnityEngine.Timeline
{
    [CustomPropertyDrawer(typeof(RhubarbPlayableBehaviour))]
    public class RhubarbPlayableDrawer : PropertyDrawer
    {/*
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            int fieldCount = 1;
            return fieldCount * EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty MouthShapeProp = property.FindPropertyRelative("MouthShape");

            Rect singleFieldRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
            EditorGUI.PropertyField(singleFieldRect, MouthShapeProp);
        }*/
    }
}
