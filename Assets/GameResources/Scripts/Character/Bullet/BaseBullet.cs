using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class BaseBullet : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _sprite;
    [SerializeField]
    protected BulletDataSO _bulletData;
    [SerializeField]
    private ParticleSystem _destroyParticle;

    protected Vector2 _startPosition;

    private Rigidbody2D _rigidbody;
    private float _conquaredDistance = 0;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _conquaredDistance = Vector2.Distance(transform.position, _startPosition);
        if (_conquaredDistance >= _bulletData.MaxDistance)
        {
            AtionToDistance();
        }
    }

    public virtual void Init(BulletDataSO bulletDataSO)
    {
        _bulletData = bulletDataSO;
        _startPosition = transform.position;
        _rigidbody.velocity = transform.up * _bulletData.Speed;
    }

    protected void DisableObject()
    {
        _rigidbody.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }

    protected abstract void AtionToCollision();
    protected abstract void AtionToDistance();

}
