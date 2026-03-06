using UnityEngine;

public class RotateDecorator : MovementDecorator
{
    private float rotationSpeed;

    public RotateDecorator(IMovement movement, float rotationSpeed) 
        : base(movement)
    {
        this.rotationSpeed = rotationSpeed;
    }

    public override void Move(Transform transform)
    {
        // normale Bewegung ausführen
        base.Move(transform);

        // zusätzliche Rotation
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}