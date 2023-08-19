using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _moveSpeed;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal*_moveSpeed,_rigidbody.velocity.y,_joystick.Vertical*_moveSpeed);
    }
}
