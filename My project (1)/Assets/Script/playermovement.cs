using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    private Rigidbody rb;
    private CustomInput input = null;
    
    [SerializeField] float velocita = 5f; 
    [SerializeField] float limiteSinistra = -5f;
    [SerializeField] float limiteDestra = 5f;

    private void Awake()
    {
        input = new CustomInput();
        rb = GetComponent<Rigidbody>();
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
        
        float nuovaPosizioneX = rb.position.x + inputX * velocita * Time.fixedDeltaTime;

        nuovaPosizioneX = Mathf.Clamp(nuovaPosizioneX, limiteSinistra, limiteDestra);

        Vector3 nuovaPosizione = new Vector3(nuovaPosizioneX, rb.position.y, rb.position.z);
                        
        rb.MovePosition(nuovaPosizione);
    }

    private void OnDestroy()
    {
        input.Dispose();
    }
}
