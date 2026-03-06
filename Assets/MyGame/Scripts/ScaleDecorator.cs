using UnityEngine;

public class ScaleDecorator : IMovementBehaviour
{
    private IMovementBehaviour wrappedBehaviour;
    private Transform transform;
    private float pulseSpeed = 2f;
    private float minScale = 0.8f;
    private float maxScale = 1.2f;
    private Vector3 originalScale;
    private float elapsedTime;

    public ScaleDecorator(IMovementBehaviour behaviour, Transform transform)
    {
        this.wrappedBehaviour = behaviour;
        this.transform = transform;
        this.originalScale = transform.localScale;
        this.elapsedTime = 0f;
    }

    public void UpdateMovement()
    {
        wrappedBehaviour.UpdateMovement();
        UpdateScale();
    }

    private void UpdateScale()
    {
        elapsedTime += Time.deltaTime;
        float scale = Mathf.Lerp(minScale, maxScale, (Mathf.Sin(elapsedTime * pulseSpeed) + 1f) / 2f);
        transform.localScale = originalScale * scale;
    }
}
