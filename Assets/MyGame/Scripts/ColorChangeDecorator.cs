using UnityEngine;

public class ColorChangeDecorator : IMovementBehaviour
{
    private IMovementBehaviour wrappedBehaviour;
    private SpriteRenderer spriteRenderer;

    public ColorChangeDecorator(IMovementBehaviour behaviour, SpriteRenderer spriteRenderer)
    {
        this.wrappedBehaviour = behaviour;
        this.spriteRenderer = spriteRenderer;
        if (behaviour is BasicMovement basic)
        {
            basic.OnBounceEvent += OnBounce;
        }
    }

    public void UpdateMovement()
    {
        wrappedBehaviour.UpdateMovement();
    }

    private void OnBounce()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = Random.ColorHSV();
        }
    }
}