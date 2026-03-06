using UnityEngine;

public class BasicMovement : IMovementBehaviour
{
    public event System.Action OnBounceEvent;

    private Transform transform;
    private Transform pointA;
    private Transform pointB;
    private float speed;
    private float reachDistance;
    private Transform currentTarget;

    public BasicMovement(Transform transform, Transform pointA, Transform pointB, float speed, float reachDistance)
    {
        this.transform = transform;
        this.pointA = pointA;
        this.pointB = pointB;
        this.speed = speed;
        this.reachDistance = reachDistance;
        this.currentTarget = pointB;
    }

    public void UpdateMovement()
    {
        Move();

        if (Vector3.Distance(transform.position, currentTarget.position) <= reachDistance)
        {
            OnBounceEvent?.Invoke();
            currentTarget = currentTarget == pointA ? pointB : pointA;
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            currentTarget.position,
            speed * Time.deltaTime
        );
    }
}