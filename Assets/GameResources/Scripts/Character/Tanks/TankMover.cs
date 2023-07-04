using UnityEngine;
using UnityEngine.Events;

public class TankMover
{
    public UnityAction<float> OnSpeedChange = delegate { };

    private TankDataSO _movementData;
    private Rigidbody2D _rb2d;
    private Vector2 _movementVector;
    private float _currentSpeed = 0;
    private float _currentForewardDirection = 1;

    public TankMover(Rigidbody2D rigidbody2D, TankDataSO movementData)
    {
        _rb2d = rigidbody2D;
        _movementData = movementData;
    }

    public void Move(Vector2 movementVector)
    {
        _movementVector = movementVector;
        CalculateSpeed(movementVector);
        OnSpeedChange?.Invoke(this._movementVector.magnitude);
        if (movementVector.y > 0)
        {
            if (_currentForewardDirection == -1)
                _currentSpeed = 0;
            _currentForewardDirection = 1;
        }
        else if (movementVector.y < 0)
        {
            if (_currentForewardDirection == 1)
                _currentSpeed = 0;
            _currentForewardDirection = -1;
        }

        _rb2d.velocity = (Vector2)_rb2d.transform.right * _currentSpeed * _currentForewardDirection * Time.fixedDeltaTime;
        _rb2d.MoveRotation(_rb2d.transform.rotation * Quaternion.Euler(0, 0, -movementVector.x * _movementData.RotationBodySpeed * Time.fixedDeltaTime));
    }

    private void CalculateSpeed(Vector2 movementVector)
    {
        if (Mathf.Abs(movementVector.y) > 0)
        {
            _currentSpeed += _movementData.Acceleration * Time.deltaTime;
        }
        else
        {
            _currentSpeed -= _movementData.Deacceleration * Time.deltaTime;
        }
        _currentSpeed = Mathf.Clamp(_currentSpeed, 0, _movementData.MaxSpeed);
    }
}