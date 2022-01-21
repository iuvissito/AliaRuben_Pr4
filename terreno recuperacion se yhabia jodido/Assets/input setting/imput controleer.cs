// GENERATED AUTOMATICALLY FROM 'Assets/input setting/imput controleer.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Imputcontroleer : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Imputcontroleer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""imput controleer"",
    ""maps"": [
        {
            ""name"": ""moverse"",
            ""id"": ""30a8b5d5-5a78-402d-827b-cd2a0278c398"",
            ""actions"": [
                {
                    ""name"": ""run"",
                    ""type"": ""Button"",
                    ""id"": ""8d10bcb0-8841-461e-ae3f-847c0e231be8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""7d49696f-068a-4df9-a300-654f0895948a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""straff l"",
                    ""type"": ""Value"",
                    ""id"": ""7015f2f6-8017-4bc4-b287-dec7955f61fb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""straff r"",
                    ""type"": ""Value"",
                    ""id"": ""40a22f3f-987b-474e-84a4-0f0b3caccc81"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""648ad979-c72a-4bac-917e-e60f91c31a23"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4bb434c-ae0e-48bb-8eb6-176e1c664ed7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7337b162-6faf-4a59-8cc4-94afad33531d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""944efe75-cf6c-49ae-9062-5e1c82e20a8d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""straff l"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b065e463-f83e-4f15-b068-7fe0f20fee14"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""straff r"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""New action map"",
            ""id"": ""ab7f278e-15da-43d2-af39-d80ba7115961"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""f7c3cc9d-662c-47b3-b5e5-2a082d45afa4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c3a3aed5-eeb1-4c49-b739-00c57763e77e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // moverse
        m_moverse = asset.FindActionMap("moverse", throwIfNotFound: true);
        m_moverse_run = m_moverse.FindAction("run", throwIfNotFound: true);
        m_moverse_move = m_moverse.FindAction("move", throwIfNotFound: true);
        m_moverse_straffl = m_moverse.FindAction("straff l", throwIfNotFound: true);
        m_moverse_straffr = m_moverse.FindAction("straff r", throwIfNotFound: true);
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_Newaction = m_Newactionmap.FindAction("New action", throwIfNotFound: true);
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

    // moverse
    private readonly InputActionMap m_moverse;
    private IMoverseActions m_MoverseActionsCallbackInterface;
    private readonly InputAction m_moverse_run;
    private readonly InputAction m_moverse_move;
    private readonly InputAction m_moverse_straffl;
    private readonly InputAction m_moverse_straffr;
    public struct MoverseActions
    {
        private @Imputcontroleer m_Wrapper;
        public MoverseActions(@Imputcontroleer wrapper) { m_Wrapper = wrapper; }
        public InputAction @run => m_Wrapper.m_moverse_run;
        public InputAction @move => m_Wrapper.m_moverse_move;
        public InputAction @straffl => m_Wrapper.m_moverse_straffl;
        public InputAction @straffr => m_Wrapper.m_moverse_straffr;
        public InputActionMap Get() { return m_Wrapper.m_moverse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoverseActions set) { return set.Get(); }
        public void SetCallbacks(IMoverseActions instance)
        {
            if (m_Wrapper.m_MoverseActionsCallbackInterface != null)
            {
                @run.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRun;
                @run.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRun;
                @run.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRun;
                @move.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnMove;
                @straffl.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffl;
                @straffl.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffl;
                @straffl.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffl;
                @straffr.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffr;
                @straffr.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffr;
                @straffr.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffr;
            }
            m_Wrapper.m_MoverseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @run.started += instance.OnRun;
                @run.performed += instance.OnRun;
                @run.canceled += instance.OnRun;
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @straffl.started += instance.OnStraffl;
                @straffl.performed += instance.OnStraffl;
                @straffl.canceled += instance.OnStraffl;
                @straffr.started += instance.OnStraffr;
                @straffr.performed += instance.OnStraffr;
                @straffr.canceled += instance.OnStraffr;
            }
        }
    }
    public MoverseActions @moverse => new MoverseActions(this);

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_Newaction;
    public struct NewactionmapActions
    {
        private @Imputcontroleer m_Wrapper;
        public NewactionmapActions(@Imputcontroleer wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Newactionmap_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface IMoverseActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnStraffl(InputAction.CallbackContext context);
        void OnStraffr(InputAction.CallbackContext context);
    }
    public interface INewactionmapActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
