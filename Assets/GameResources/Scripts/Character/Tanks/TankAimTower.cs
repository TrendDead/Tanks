using UnityEngine;

public class TankAimTower
{
    private GameObject _tankTower;
    private TankDataSO _tankData;

    public TankAimTower(GameObject tankTower, TankDataSO tankData)
    {
        _tankTower = tankTower;
        _tankData = tankData;
    }

    public void Aim(Vector2 inputPointerPosition)
    {
        var turretDirection = (Vector3)inputPointerPosition - _tankTower.transform.position;
        var desiredAngle = Mathf.Atan2(turretDirection.y, turretDirection.x) * Mathf.Rad2Deg;
        var rotationStep = _tankData.TowerRotationSpeed * Time.deltaTime;

        _tankTower.transform.rotation = Quaternion.RotateTowards(_tankTower.transform.rotation, Quaternion.Euler(0, 0, desiredAngle), rotationStep);
    }
}
