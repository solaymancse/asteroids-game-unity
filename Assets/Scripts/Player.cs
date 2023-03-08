using UnityEngine;

public class Player : MonoBehaviour
{
  private RigidBody2D _rigidbody;
  private bool _thrusting;
  private float _turnDirection;

  private void Awake(){
   _rigidbody = GetComponent<RigidBody2D>();
  }

  private void Update(){
    _thrusting = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);

    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.LeftArrow)){
        _turnDirection = 1.0f;
    }else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow)){
        _turnDirection = -1.0f;
    }else{
        _turnDirection = 0.0f;
    }
  }

  private void FixedUpdate(){

  }
}
