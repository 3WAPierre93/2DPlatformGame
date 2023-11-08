using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//peut-être un déplacement ?
public float _horizontal,

//vitesse de déplacement
public float _speed;

float horizonthalInput = Input.GetAxisRaw("Horizonthal");


direction *= _speed * Time.deltaTime;