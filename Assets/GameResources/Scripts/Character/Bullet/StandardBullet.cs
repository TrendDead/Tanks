using UnityEngine;

public class StandardBullet : BaseBullet
{
    protected override void AtionToCollision()
    {
        Debug.Log("Вызываем взрыв");
    }

    protected override void AtionToDistance()
    {
        DisableObject();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //OnHit?.Invoke();

        //var damagable = collision.GetComponent<IDamagable>();
        //if (damagable != null)
        //{
        //    damagable.Hit(_bulletData.Damage);
        //}

        AtionToCollision();
        DisableObject();
    }
}
