using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;
    InputAction moveAction;
    InputAction rotateAction;

    // Start is called before the first frame update
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rotateAction = InputSystem.actions.FindAction("Rotate");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = rotateAction.ReadValue<Vector2>().x;
        verticalInput = moveAction.ReadValue<Vector2>().y;
        if (verticalInput > 0)
        {
            // Move o ve�culo para frente a partir do Input vertical
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        }
        // Rotaciona o carro a partir do Input horizontal
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
