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
//peut-�tre un d�placement ?
public float _horizontal,

//vitesse de d�placement
public float _speed;

float horizonthalInput = Input.GetAxisRaw("Horizonthal");


direction *= _speed * Time.deltaTime;