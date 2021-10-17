using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEditor;
using UnityEngine.Events;

namespace Triktron.Combo
{
    public class CombinationManager : MonoBehaviour, ComboInputReader.IComboActions
    {
        ComboInputReader Input;

        public int MaxHistory = 20;
        [Range(0,1)]
        public float JoystickThreshold = .6f;
        public float Timeout = 1.5f;
        public List<InputCombination> Combinations = new List<InputCombination>();
        public UnityEvent<InputCombination> OnCombo;
        private List<KeyState> _history = new List<KeyState>();
        private Vector2 _lastMove;
        private float _time;

        #region Button Callbacks
        public void OnBtnEast(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.BtnEast, context);
        }

        public void OnBtnNorth(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.BtnNorth, context);
        }

        public void OnBtnSouth(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.BtnSouth, context);
        }

        public void OnBtnWest(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.BtnWest, context);
        }

        public void OnDown(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.Down, context);
        }

        public void OnL1(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.L1, context);
        }

        public void OnL2(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.L2, context);
        }

        public void OnLeft(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.Left, context);
        }

        public void OnR1(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.R1, context);
        }

        public void OnR2(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.R2, context);
        }

        public void OnRight(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.Right, context);
        }

        public void OnUp(InputAction.CallbackContext context)
        {
            OnKey(InputCombinationKey.KeysTypes.Up, context);
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            var input = context.ReadValue<Vector2>();

            if (Mathf.Abs(input.x) > JoystickThreshold) input.x = Mathf.Sign(input.x);
            else input.x = 0;

            if (Mathf.Abs(input.y) > JoystickThreshold) input.y = Mathf.Sign(input.y);
            else input.y = 0;

            if (_lastMove.x == 1 && input.x == 0) OnKey(InputCombinationKey.KeysTypes.Right, false);
            if (_lastMove.x == 0 && input.x == 1) OnKey(InputCombinationKey.KeysTypes.Right, true);
            if (_lastMove.x == -1 && input.x == 0) OnKey(InputCombinationKey.KeysTypes.Left, false);
            if (_lastMove.x == 0 && input.x == -1) OnKey(InputCombinationKey.KeysTypes.Left, true);
            if (_lastMove.y == 1 && input.y == 0) OnKey(InputCombinationKey.KeysTypes.Up, false);
            if (_lastMove.y == 0 && input.y == 1) OnKey(InputCombinationKey.KeysTypes.Up, true);
            if (_lastMove.y == -1 && input.y == 0) OnKey(InputCombinationKey.KeysTypes.Down, false);
            if (_lastMove.y == 0 && input.y == -1) OnKey(InputCombinationKey.KeysTypes.Down, true);

            _lastMove = input;
        }
        #endregion

        private void OnEnable()
        {
            Input = new ComboInputReader();

            Input.Combo.SetCallbacks(this);

            EnableGameplayInput();
        }

        private void Update()
        {
            _time += Time.deltaTime;
            if (_time > Timeout) _history.Clear();

#if UNITY_EDITOR
            EditorUtility.SetDirty(this);
#endif
        }

        private void OnDisable()
        {
            DisableAllInput();
        }

        public void EnableGameplayInput()
        {
            Input.Combo.Enable();
        }

        public void DisableAllInput()
        {
            Input.Combo.Disable();
        }

        private void OnKey(InputCombinationKey.KeysTypes key, InputAction.CallbackContext context)
        {
            if (context.performed) return;

            OnKey(key, context.started);
        }

        private void OnKey(InputCombinationKey.KeysTypes key, bool pressed)
        {
            _history.Add(new KeyState() { State = pressed ? KeyState.States.Down : KeyState.States.Up, Key = key });

            if (_history.Count > MaxHistory) _history.RemoveAt(0);

            _time = 0;

            CheckForCommbos();

#if UNITY_EDITOR
            EditorUtility.SetDirty(this);
#endif
        }

        private void CheckForCommbos()
        {
            foreach (var canidate in Combinations)
            {
                if (CheckCombination(canidate))
                {
                    OnCombo.Invoke(canidate);
                    canidate.OnCombo.Invoke();
                    _history.Clear();
                }
            }
        }

        private bool CheckCombination(InputCombination canidate)
        {
            int hi = _history.Count - 1; // history index
            for (int i = canidate.Keys.Count - 1; i >= 0; i--)
            {
                if (hi >= 0 && canidate.Keys[i].State == InputCombinationKey.StatesTypes.Down)
                {
                    if (canidate.Keys[i].Key != _history[hi].Key || _history[hi].State != KeyState.States.Down) return false;
                }
                else if (hi >= 0 && canidate.Keys[i].State == InputCombinationKey.StatesTypes.Up)
                {
                    if (canidate.Keys[i].Key != _history[hi].Key || _history[hi].State != KeyState.States.Up) return false;
                }
                else
                if (hi >= 1 && canidate.Keys[i].State == InputCombinationKey.StatesTypes.UpAndDown)
                {
                    if (canidate.Keys[i].Key != _history[hi].Key || _history[hi].State != KeyState.States.Up) return false;
                    hi--;
                    if (canidate.Keys[i].Key != _history[hi].Key || _history[hi].State != KeyState.States.Down) return false;
                }
                else return false;
                hi--;
            }

            return true;
        }

        public List<KeyState> GetHistory()
        {
            return _history;
        }

        [System.Serializable]
        public class KeyState
        {
            public enum States
            {
                Up,
                Down
            }

            public States State;
            public InputCombinationKey.KeysTypes Key;
        }
    }
}