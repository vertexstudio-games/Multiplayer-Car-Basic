using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float turnSpeed;
    private float horizontalInput;
    private float forwardInput;

    [SerializeField] private string inputID;

    [SerializeField] public Camera mainCamera;
    [SerializeField] public Camera hoodCamera;

    [SerializeField] public KeyCode switchKey;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // We'll move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Outras direçoes que seraõ muito usadas (úteis)
        // Vector3.forward // frente
        // Vector3.back    // trás
        // Vector3.right   // direita
        // Vector3.left    // esquerda
        // Vector3.up      // cima
        // Vector3.down    // baixo

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
