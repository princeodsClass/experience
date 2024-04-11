using UnityEngine;

public class CharacterController : MonoBehaviour
{
    FloatingJoystick _floatingJoystick = null;

    Animator _animator = null;
    Rigidbody _rigidbody = null;

    Vector3 _direction = Vector3.zero;

    float _fRunSpeed = 5.5f;

    bool _isGround, _isBlock;

    private void Awake()
    {
        _floatingJoystick = FindObjectOfType<FloatingJoystick>();

        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Footstep(Object prefab)
    {
    }

    public void Land(Object prefab)
    {
    }

    void CharacterMove()
    {
        _direction = new Vector3(_floatingJoystick.Direction.x,
                         0,
                         _floatingJoystick.Direction.y);
        _fRunSpeed = Mathf.Lerp(0, 5.5f, _direction.magnitude);

        _rigidbody.MovePosition(_rigidbody.position + _direction.normalized * _fRunSpeed * Time.deltaTime);
        transform.LookAt(transform.position + _direction);
        SetCharacterAnimation();
    }

    void SetCharacterAnimation()
    {
        if ( _isGround )
        {
            _animator.ResetTrigger("Floating");
            _animator.SetTrigger("Landing");

            _animator.SetFloat("Theshold", _floatingJoystick.Direction.magnitude);
            _animator.SetBool("isMove", _floatingJoystick.Direction.magnitude > 0);
        }
        else
        {
            _animator.ResetTrigger("Landing");
            _animator.SetTrigger("Floating");
        }
        
    }

    //private void FixedUpdate()
    private void Update()
    {
        _isGround = Physics.Raycast(transform.position + transform.up * 0.35f,
                                  transform.up * -1,
                                  0.5f,
                                  LayerMask.GetMask("Structure"));

        CharacterMove();
    }
}
