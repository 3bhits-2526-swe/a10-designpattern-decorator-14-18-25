using UnityEngine;

public class RotateDecorator : IMovementBehaviour
{
    private IMovementBehaviour wrappedBehaviour;
    private Transform transform;
    private float rotationSpeed;

    public RotateDecorator(IMovementBehaviour behaviour, Transform transform, float rotationSpeed)
    {
        this.wrappedBehaviour = behaviour;
        this.transform = transform;
        this.rotationSpeed = rotationSpeed;
    }

    public void UpdateMovement()
    {
        // normale Bewegung ausführen
        wrappedBehaviour.UpdateMovement();

        // zusätzliche Rotation
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}