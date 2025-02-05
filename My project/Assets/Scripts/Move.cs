using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;

    [SerializeField] private Rigidbody rb;

    // on enable

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        //create movement vector

        Vector3 move = new Vector3(moveX, 0.0f, moveZ) * moveSpeed * Time.deltaTime;
        
        transform.Translate(move, Space.World);

    }
}
