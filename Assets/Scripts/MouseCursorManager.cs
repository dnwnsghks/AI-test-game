using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class MouseCursorManager : MonoBehaviour
{
    private InputSystemUIInputModule uiInputModule;
    // Start is called before the first frame update
    void Start()
    {
        uiInputModule = FindObjectOfType<InputSystemUIInputModule>();

        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // 클릭할 때 커서 상태 유지
            if (!Cursor.visible || Cursor.lockState != CursorLockMode.None)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            Vector3 mousePosition = Mouse.current.position.ReadValue();
            UnityEngine.Debug.Log($"Mouse Clicked at: {mousePosition}");
        }
    }
}
