using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D leftArm;
    [SerializeField] Rigidbody2D rightArm;
    [SerializeField] float forceAmount;

    bool isPressKeyLeft => Input.GetKeyDown(KeyCode.A);
    bool isPressKeyRight => Input.GetKeyDown(KeyCode.D);

    void Update() 
    {
        if(isPressKeyLeft) { Hit(leftArm); }
        else if(isPressKeyRight) { Hit(rightArm); }
    }

    void Hit(Rigidbody2D currentRigid)
    {
        currentRigid.AddForce(Vector2.up * forceAmount);
    }

}
