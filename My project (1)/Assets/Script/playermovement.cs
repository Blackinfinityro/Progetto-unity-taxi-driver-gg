using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    private CustomInput input = null;

    private void Awake()
    {
        input = new CustomInput();
    }


    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    void Update()
    {
        transform.Translate(input.Player.Movement.ReadValue<Vector2>().x * 5 * Time.deltaTime * Vector2.right);
    }   

    void OnDestroy()
    {
        input.Dispose();
    }
}
