using UnityEngine;

namespace BaseClasses
{
    public class PlayerCameraManager : CameraManager
    {
        [Header("Constraints")] public float minPitch = -90f;

        public float maxPitch = 90f;

        //Add pitch to the camera
        public void AddPitch(float pitch)
        {
            var cameraTransform = GetView().transform;

            if (cameraTransform != null)
            {
                //Set the pitch with clamping
                var currentRotation = cameraTransform.localRotation;

                //Fix euler angles negative values
                var currentPitch = cameraTransform.localEulerAngles.x;

                if (currentPitch > 180) currentPitch -= 360;

                var newRotation = Quaternion.Euler(Mathf.Clamp(currentPitch + pitch, minPitch, maxPitch)
                    , currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);

                //Set the new rotation
                cameraTransform.localRotation = newRotation;
            }
        }
    }
}