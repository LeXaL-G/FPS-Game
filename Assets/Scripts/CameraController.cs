using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private Transform player;
   [SerializeField] private float mouseSensitivity=100f;
   private float xRotation;
   [SerializeField] CharakterController _charakterController;
   private void Start()
   {
      Cursor.lockState = CursorLockMode.Locked;
   }

   private void Update()
   {
      float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
      
      
      xRotation -= mouseY;
      xRotation = Mathf.Clamp(xRotation, -90f, 90f);
      transform.localRotation=Quaternion.Euler(xRotation,0f,0f);
      player.Rotate(Vector3.up*mouseX);
   }
}
