using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 3.0f;
    [SerializeField]
    private float chaseRadius = 10.0f;
    [SerializeField]
    private Transform player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= chaseRadius)
        {
            ChasePlayer();
        }

    }

    private void ChasePlayer()
    {
        Vector3 direction = (player.position - transform.position).normalized;

        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }
}
