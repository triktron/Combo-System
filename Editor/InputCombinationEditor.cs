using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

namespace Triktron.Combo
{
	[CustomEditor(typeof(InputCombination))]
	public class InputCombinationEditor : Editor
	{
		private ReorderableList list;
		SerializedProperty _onCombo;

		private void OnEnable()
		{
			_onCombo = serializedObject.FindProperty("OnCombo");
			list = new ReorderableList(serializedObject, serializedObject.FindProperty("Keys"), true, true, true, true);

			list.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) => {
				var element = list.serializedProperty.GetArrayElementAtIndex(index);
				rect.y += 2;
				EditorGUI.LabelField(new Rect(rect.x, rect.y, 30, EditorGUIUtility.singleLineHeight), "Key:");
				EditorGUI.PropertyField(new Rect(rect.x + 30, rect.y, 120, EditorGUIUtility.singleLineHeight), element.FindPropertyRelative("Key"), GUIContent.none);
				EditorGUI.LabelField(new Rect(rect.x + 160, rect.y, 40, EditorGUIUtility.singleLineHeight), "State:");
				EditorGUI.PropertyField(new Rect(rect.x + 200, rect.y, 120, EditorGUIUtility.singleLineHeight), element.FindPropertyRelative("State"), GUIContent.none);
			};
			list.drawHeaderCallback = (Rect rect) => {
				EditorGUI.LabelField(rect, "Keys");
			};
			list.onCanRemoveCallback = (ReorderableList l) => {
				return l.count > 1;
			};
			list.onRemoveCallback = (ReorderableList l) => {
				//if (EditorUtility.DisplayDialog("Warning!", "Are you sure you want to delete the wave?", "Yes", "No"))
				//{
				ReorderableList.defaultBehaviours.DoRemoveButton(l);
				//}
			};
			list.onAddCallback = (ReorderableList l) => {
				var index = l.serializedProperty.arraySize;
				l.serializedProperty.arraySize++;
				l.index = index;
				var element = l.serializedProperty.GetArrayElementAtIndex(index);
				//element.FindPropertyRelative("Key").enumValueIndex = 0;
				//element.FindPropertyRelative("State").intValue = 20;
			};
		}

		public override void OnInspectorGUI()
		{
			serializedObject.Update();
			list.DoLayoutList();
			EditorGUILayout.PropertyField(_onCombo);
			serializedObject.ApplyModifiedProperties();
		}
	}
}