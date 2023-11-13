using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Walk : MonoBehaviour
{
    //peut-être un déplacement ?
    public float _horizontal,
                 _vertical;

    //vitesse de déplacement
    public float _speed;

    #region Exposed
    [SerializeField]
    private float _moveSpeed = 10f;
    #endregion
    void Awake()
    {
        _rgbd = GetComponent<Rigidbody2D>();
    }

     void Start()
     {
        
     }
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizonthal") * _moveSpeed;
    }
    void FixedUpdate()
    {
        _rgbd.velocity = _direction;
    }

    #region Private
    private Rigidbody2D _rgbd;
    private Vector2 _direction;
    #endregion














}
































