using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverMotor : MonoBehaviour
{
    public float speed = 90f;
    public float turnSpeed = 5f;
    public float hoverForce = 65f;
    public float hoverHeight = 3.5f;

    private float powerInput;
    private float turnInput;
    private Rigidbody rb;

    [SerializeField] private PlayerTriggerHandler player;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        powerInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, hoverHeight)) {
            float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
            Vector3 appliedHoverForce = Vector3.up * proportionalHeight * hoverForce;
            rb.AddForce(appliedHoverForce, ForceMode.Acceleration);
        };

        if(player.canMove) {
            rb.AddRelativeForce(0f, 0f, powerInput * speed);
            rb.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);
        }
    }
}
