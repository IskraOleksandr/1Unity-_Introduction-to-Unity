using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float x_rotate_speed = 1.0F;
	[SerializeField]
	private float y_rotate_speed = 0.5F;
	[SerializeField]
	private float z_rotate_speed = 0.8F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x_rotate_speed, y_rotate_speed, z_rotate_speed);
    }
}
