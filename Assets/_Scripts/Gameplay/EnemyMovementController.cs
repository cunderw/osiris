using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour {

    private Rigidbody rBody;
    private Vector3 moveDir;
    public float moveForce = 0f;
    public LayerMask whatIsWall;
    public float maxDistFromWall = 0f;

    // Start is called before the first frame update
    void Start() {
        rBody = GetComponent<Rigidbody>();
        moveDir = ChooseDirection();
        transform.rotation = Quaternion.LookRotation(moveDir);
    }

    // Update is called once per frame
    void Update() {
        rBody.velocity = moveDir * moveForce;
        if (Physics.Raycast(transform.position, transform.forward, maxDistFromWall, whatIsWall)) {
            moveDir = ChooseDirection();
            transform.rotation = Quaternion.LookRotation(moveDir);
        }
    }

    Vector3 ChooseDirection() {
        System.Random ran = new System.Random();
        int i = ran.Next(0, 3);
        Vector3 temp = new Vector3();
        switch (i) {
            case 0:
                temp = transform.forward;
                break;
            case 1:
                temp = -transform.forward;
                break;
            case 2:
                temp = transform.right;
                break;
            case 3:
                temp = -transform.right;
                break;
        }
        return temp;
    }
}