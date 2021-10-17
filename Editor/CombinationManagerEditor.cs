using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Triktron.Combo
{
    [CustomEditor(typeof(CombinationManager))]
    public class CombinationManagerEditor : Editor
    {
        string _updateText;
        float timeLeft;

        void OnEnable()
        {
            EditorApplication.update += Update;
            ((CombinationManager)target).OnCombo.AddListener(OnCombo);
        }
        void OnDisable() {
            EditorApplication.update -= Update; 
            timeLeft = 0; 
            ((CombinationManager)target).OnCombo.RemoveListener(OnCombo);
        }

        private void OnCombo(InputCombination combo)
        {
            _updateText = combo.name;
            timeLeft = 1;
        }

        public void Update()
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                Repaint();
            }
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            List<CombinationManager.KeyState> keys = ((CombinationManager)target).GetHistory();

            GUIStyle style = new GUIStyle();
            style.richText = true;

            GUILayout.Label($"<color=white><size=20><b>Last Combo:</b> {(timeLeft > 0 ? _updateText : "")}</size></color>", style);
            GUILayout.Label("<color=white><size=20><b>History:</b></size></color>", style);

            foreach (var key in keys)
            {
                GUILayout.Label($"<color=white><b>Key:</b></color><color=lightblue>{key.Key}</color> <color=white><b>State:</b></color><color={(key.State == CombinationManager.KeyState.States.Up ? "red" : "green")}>{key.State}</color> ", style);
            }
        }
    }
}