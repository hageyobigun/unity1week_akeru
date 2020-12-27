using UnityEngine;

public class PlayerInput
{
    public bool IsOpenHole() => Input.GetMouseButtonDown(0);

    public bool IsRotation() => Input.GetKey(KeyCode.A);

}
