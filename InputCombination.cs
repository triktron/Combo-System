using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Triktron.Combo
{
    [CreateAssetMenu(fileName = "SO_InputCombination", menuName = "Game/Input Combination")]
    public class InputCombination : ScriptableObject
    {
        public List<InputCombinationKey> Keys = new List<InputCombinationKey>();
        public UnityEvent OnCombo = new UnityEvent();
    }

    [System.Serializable]
    public class InputCombinationKey
    {
        public enum KeysTypes
        {
            Up,
            Down,
            Left,
            Right,
            BtnNorth,
            BtnEast,
            BtnSouth,
            BtnWest,
            L1,
            L2,
            R1,
            R2
        }

        public enum StatesTypes
        {
            UpAndDown,
            Up,
            Down
        }

        public static readonly Dictionary<KeysTypes, string> KeysTypesNames = new Dictionary<KeysTypes, string>() {
            { KeysTypes.Up, "↑"},
            { KeysTypes.Down, "↓"},
            { KeysTypes.Left, "←"},
            { KeysTypes.Right, "→"},
            { KeysTypes.BtnNorth, "North"},
            { KeysTypes.BtnEast, "East"},
            { KeysTypes.BtnSouth, "South"},
            { KeysTypes.BtnWest, "West"},
            { KeysTypes.L1, "L1"},
            { KeysTypes.L2, "L2"},
            { KeysTypes.R1, "R1"},
            { KeysTypes.R2, "R2"}
        };

        public KeysTypes Key;
        public StatesTypes State;
    }
}