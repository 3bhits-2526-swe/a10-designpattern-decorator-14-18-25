using UnityEngine;

public class MoveBetweenPoints : MonoBehaviour
{
    [Header("Points")]
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;

    [Header("Movement")]
    [SerializeField] private float speed = 2f;
    [SerializeField] private float reachDistance = 0.05f;

    [Header("Decorators")]
    [SerializeField] private bool changeColorOnBounce = true;
    [SerializeField] private bool enableScaling = true;

    private IMovementBehaviour movementBehaviour;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        IMovementBehaviour basic = new BasicMovement(transform, pointA, pointB, speed, reachDistance);
        
        // Apply ColorChangeDecorator if enabled
        if (changeColorOnBounce)
        {
            basic = new ColorChangeDecorator(basic, spriteRenderer);
        }
        
        // Apply ScaleDecorator if enabled
        if (enableScaling)
        {
            basic = new ScaleDecorator(basic, transform);
        }
        
        movementBehaviour = basic;
    }

    private void Update()
    {
        movementBehaviour.UpdateMovement();
    }
}