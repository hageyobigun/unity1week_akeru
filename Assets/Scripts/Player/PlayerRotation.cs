using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation
{
    private readonly GameObject block;
    private float rotationAngle;

    public PlayerRotation(GameObject _block)
    {
        rotationAngle = 0;
        block = _block;
    }

    public void Rotation()
    {
        rotationAngle += 1;
        block.transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
    }
}
