using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _playerInput;
    [Header("Tank Settings")]
    [SerializeField]
    private TankDataSO _movementData;
    [Header("Tank Move Components")]
    [SerializeField]
    private Rigidbody2D _rigidbody;
    [Header("Tank Tower Components")]
    [SerializeField]
    private GameObject _tankTower;
    [SerializeField]
    private SpriteRenderer _tankTowerSprite;
    [SerializeField]
    private Transform _transformTowerShot;
    [SerializeField]
    private TowerDataSO[] _towers;

    private TankAimTower _aimTower;
    private TankMover _tankMover;
    private TankTowerController _towerShoter; // ћожно ли его переделать без монобеха

    //public TankTowerController[] towers;

    private void Awake()
    {
        InitObject();
    }

    public void InitObject()
    {
        _tankMover = new TankMover(_rigidbody, _movementData);
        _playerInput.ToMoveBody += _tankMover.Move;

        _aimTower = new TankAimTower(_tankTower, _movementData);
        _playerInput.ToMoveTower += _aimTower.Aim;
    }

    private void OnDestroy()
    {
        _playerInput.ToMoveBody -= _tankMover.Move;
        _playerInput.ToMoveTower -= _aimTower.Aim;
        
    }
}