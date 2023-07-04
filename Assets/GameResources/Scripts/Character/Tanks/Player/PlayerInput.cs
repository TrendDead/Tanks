using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public UnityAction ToShoot = delegate { };
    public UnityAction<Vector2> ToMoveBody = delegate { };
    public UnityAction<Vector2> ToMoveTower = delegate { };
    
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update() //Мб кэшировать все Update
    {
        GetBodyMovement();
        GetTowerMovement();
        GetShootingInput();
    }

    private void GetShootingInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToShoot?.Invoke();
        }
    }

    private void GetTowerMovement()
    {
        ToMoveTower?.Invoke(GetMousePositon());
    }

    private Vector2 GetMousePositon()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.nearClipPlane;
        Vector2 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        return mouseWorldPosition;
    }

    private void GetBodyMovement()
    {
        Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //Потом переделать под new Input System
        ToMoveBody?.Invoke(movementVector.normalized);
    }
}