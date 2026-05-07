using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    private Rigidbody rb;
    private CustomInput input = null;
    [SerializeField] int velocita = 0;
    [SerializeField] float limiteSinistra = -5f;
    [SerializeField] float limiteDestra = 5f;

    private void Awake()
    {
        input = new CustomInput();
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
    }


    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    void FixedUpdate()
    {
        float inputX = input.Player.Movement.ReadValue<Vector2>().x;
        float nuovaPosizioneX = transform.position.x + inputX * Time.fixedDeltaTime * velocita;

        nuovaPosizioneX = Mathf.Clamp(nuovaPosizioneX, limiteSinistra, limiteDestra);

        Vector3 nuovaPosizione = new Vector3(nuovaPosizioneX, transform.position.y, transform.position.z);        
        
        rb.MovePosition(nuovaPosizione);
    }

    void OnDestroy()
    {
        input.Dispose();
    }
}