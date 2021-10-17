// GENERATED AUTOMATICALLY FROM 'Assets/Settings/ComboInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Triktron.Combo
{
    public class @ComboInputReader : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @ComboInputReader()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""ComboInput"",
    ""maps"": [
        {
            ""name"": ""Combo"",
            ""id"": ""77e8024d-86bb-4dac-bc83-62d33c0c20be"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""69848d3a-29a5-41cf-9cec-a38215ef624b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""53380d24-76f2-441e-8d6e-e027d8ab9716"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""499983f4-7ffe-4e0d-b853-26576b713775"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""2e7bc0c8-4818-4c61-a415-af719c60cd3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BtnNorth"",
                    ""type"": ""Button"",
                    ""id"": ""82ee36ae-efb2-4cf0-a539-8682b673fd68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BtnEast"",
                    ""type"": ""Button"",
                    ""id"": ""fa61ae40-37a2-4322-b7c6-4cae68a686db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BtnSouth"",
                    ""type"": ""Button"",
                    ""id"": ""c3f55115-2be6-487a-b572-2efe41235160"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BtnWest"",
                    ""type"": ""Button"",
                    ""id"": ""c2699943-f1c0-437c-a2f1-7592a5c6e095"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""a518a5fa-c2ee-43a2-a0e1-1030715bfe4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""486d5dd0-e4fc-4029-afe3-437b84046e39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""9121275d-c097-4993-934b-d0ef8ab6eed8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""4a6b80a1-fac9-4290-a08c-52098d05cfa5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d036fa41-d887-44e8-8598-53b5992b3c5a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9249e299-aeeb-4322-9747-ad98ff13d252"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd488914-2d32-4372-94ed-1d24ea51a902"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7566e1c7-de7e-479e-aa13-8c01d185527f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c9901eb-dc46-40e5-90df-03340f6cbdf5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d03c21ce-f737-48b3-81f9-c770b465ae51"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bb07b97-e95d-4ece-bced-1b280e2b9299"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4edc2a8b-f5e9-4210-b368-a269ff11abf2"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8aee948-7141-4446-b7d5-7bfeea62ce68"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""423faccc-dd2c-4344-bbbc-44fb4709aba6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BtnNorth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d2c1130-c999-41ad-8bfb-789e2d4e6262"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BtnEast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7332544-0edb-4700-ad91-ae44d2fc2075"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BtnSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41a823b6-0b0c-403d-80bc-5221bb5e9577"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BtnWest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""237a6be4-9443-49f8-9b2b-ab07aa3d1b3c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed3df92d-32a5-4e0d-96db-c4c70de9de9f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dc70c84-5ef6-4889-b209-ffddba8e14e2"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75d7c414-abd2-4b0f-9109-4e2c06a5a6fb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9e88082-b6e8-4065-8802-a725c3b379af"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Combo
            m_Combo = asset.FindActionMap("Combo", throwIfNotFound: true);
            m_Combo_Up = m_Combo.FindAction("Up", throwIfNotFound: true);
            m_Combo_Down = m_Combo.FindAction("Down", throwIfNotFound: true);
            m_Combo_Left = m_Combo.FindAction("Left", throwIfNotFound: true);
            m_Combo_Right = m_Combo.FindAction("Right", throwIfNotFound: true);
            m_Combo_BtnNorth = m_Combo.FindAction("BtnNorth", throwIfNotFound: true);
            m_Combo_BtnEast = m_Combo.FindAction("BtnEast", throwIfNotFound: true);
            m_Combo_BtnSouth = m_Combo.FindAction("BtnSouth", throwIfNotFound: true);
            m_Combo_BtnWest = m_Combo.FindAction("BtnWest", throwIfNotFound: true);
            m_Combo_L1 = m_Combo.FindAction("L1", throwIfNotFound: true);
            m_Combo_L2 = m_Combo.FindAction("L2", throwIfNotFound: true);
            m_Combo_R1 = m_Combo.FindAction("R1", throwIfNotFound: true);
            m_Combo_R2 = m_Combo.FindAction("R2", throwIfNotFound: true);
            m_Combo_Move = m_Combo.FindAction("Move", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Combo
        private readonly InputActionMap m_Combo;
        private IComboActions m_ComboActionsCallbackInterface;
        private readonly InputAction m_Combo_Up;
        private readonly InputAction m_Combo_Down;
        private readonly InputAction m_Combo_Left;
        private readonly InputAction m_Combo_Right;
        private readonly InputAction m_Combo_BtnNorth;
        private readonly InputAction m_Combo_BtnEast;
        private readonly InputAction m_Combo_BtnSouth;
        private readonly InputAction m_Combo_BtnWest;
        private readonly InputAction m_Combo_L1;
        private readonly InputAction m_Combo_L2;
        private readonly InputAction m_Combo_R1;
        private readonly InputAction m_Combo_R2;
        private readonly InputAction m_Combo_Move;
        public struct ComboActions
        {
            private @ComboInputReader m_Wrapper;
            public ComboActions(@ComboInputReader wrapper) { m_Wrapper = wrapper; }
            public InputAction @Up => m_Wrapper.m_Combo_Up;
            public InputAction @Down => m_Wrapper.m_Combo_Down;
            public InputAction @Left => m_Wrapper.m_Combo_Left;
            public InputAction @Right => m_Wrapper.m_Combo_Right;
            public InputAction @BtnNorth => m_Wrapper.m_Combo_BtnNorth;
            public InputAction @BtnEast => m_Wrapper.m_Combo_BtnEast;
            public InputAction @BtnSouth => m_Wrapper.m_Combo_BtnSouth;
            public InputAction @BtnWest => m_Wrapper.m_Combo_BtnWest;
            public InputAction @L1 => m_Wrapper.m_Combo_L1;
            public InputAction @L2 => m_Wrapper.m_Combo_L2;
            public InputAction @R1 => m_Wrapper.m_Combo_R1;
            public InputAction @R2 => m_Wrapper.m_Combo_R2;
            public InputAction @Move => m_Wrapper.m_Combo_Move;
            public InputActionMap Get() { return m_Wrapper.m_Combo; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ComboActions set) { return set.Get(); }
            public void SetCallbacks(IComboActions instance)
            {
                if (m_Wrapper.m_ComboActionsCallbackInterface != null)
                {
                    @Up.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnUp;
                    @Up.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnUp;
                    @Up.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnUp;
                    @Down.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnDown;
                    @Down.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnDown;
                    @Down.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnDown;
                    @Left.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnLeft;
                    @Left.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnLeft;
                    @Left.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnLeft;
                    @Right.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnRight;
                    @Right.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnRight;
                    @Right.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnRight;
                    @BtnNorth.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnNorth;
                    @BtnNorth.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnNorth;
                    @BtnNorth.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnNorth;
                    @BtnEast.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnEast;
                    @BtnEast.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnEast;
                    @BtnEast.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnEast;
                    @BtnSouth.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnSouth;
                    @BtnSouth.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnSouth;
                    @BtnSouth.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnSouth;
                    @BtnWest.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnWest;
                    @BtnWest.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnWest;
                    @BtnWest.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnBtnWest;
                    @L1.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnL1;
                    @L1.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnL1;
                    @L1.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnL1;
                    @L2.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnL2;
                    @L2.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnL2;
                    @L2.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnL2;
                    @R1.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnR1;
                    @R1.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnR1;
                    @R1.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnR1;
                    @R2.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnR2;
                    @R2.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnR2;
                    @R2.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnR2;
                    @Move.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_ComboActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Up.started += instance.OnUp;
                    @Up.performed += instance.OnUp;
                    @Up.canceled += instance.OnUp;
                    @Down.started += instance.OnDown;
                    @Down.performed += instance.OnDown;
                    @Down.canceled += instance.OnDown;
                    @Left.started += instance.OnLeft;
                    @Left.performed += instance.OnLeft;
                    @Left.canceled += instance.OnLeft;
                    @Right.started += instance.OnRight;
                    @Right.performed += instance.OnRight;
                    @Right.canceled += instance.OnRight;
                    @BtnNorth.started += instance.OnBtnNorth;
                    @BtnNorth.performed += instance.OnBtnNorth;
                    @BtnNorth.canceled += instance.OnBtnNorth;
                    @BtnEast.started += instance.OnBtnEast;
                    @BtnEast.performed += instance.OnBtnEast;
                    @BtnEast.canceled += instance.OnBtnEast;
                    @BtnSouth.started += instance.OnBtnSouth;
                    @BtnSouth.performed += instance.OnBtnSouth;
                    @BtnSouth.canceled += instance.OnBtnSouth;
                    @BtnWest.started += instance.OnBtnWest;
                    @BtnWest.performed += instance.OnBtnWest;
                    @BtnWest.canceled += instance.OnBtnWest;
                    @L1.started += instance.OnL1;
                    @L1.performed += instance.OnL1;
                    @L1.canceled += instance.OnL1;
                    @L2.started += instance.OnL2;
                    @L2.performed += instance.OnL2;
                    @L2.canceled += instance.OnL2;
                    @R1.started += instance.OnR1;
                    @R1.performed += instance.OnR1;
                    @R1.canceled += instance.OnR1;
                    @R2.started += instance.OnR2;
                    @R2.performed += instance.OnR2;
                    @R2.canceled += instance.OnR2;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public ComboActions @Combo => new ComboActions(this);
        public interface IComboActions
        {
            void OnUp(InputAction.CallbackContext context);
            void OnDown(InputAction.CallbackContext context);
            void OnLeft(InputAction.CallbackContext context);
            void OnRight(InputAction.CallbackContext context);
            void OnBtnNorth(InputAction.CallbackContext context);
            void OnBtnEast(InputAction.CallbackContext context);
            void OnBtnSouth(InputAction.CallbackContext context);
            void OnBtnWest(InputAction.CallbackContext context);
            void OnL1(InputAction.CallbackContext context);
            void OnL2(InputAction.CallbackContext context);
            void OnR1(InputAction.CallbackContext context);
            void OnR2(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
        }
    }
}
