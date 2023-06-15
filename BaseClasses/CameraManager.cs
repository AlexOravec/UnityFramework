using UnityEngine;

namespace BaseClasses
{
    public class CameraManager : Object
    {
        // Reference to the camera
        private Camera _camera;

        // Reference to the cinematic camera
        private Camera _cinematicCamera;

        //Set the camera
        public void SetView(Object actor)
        {
            _camera = actor.GetComponentInChildren<Camera>();

            // Check if the camera is null
            if (_camera == null) Debug.LogError("Failed to find camera component on actor " + actor.name);
        }

        //Get the camera
        public Camera GetView()
        {
            return _camera;
        }

        //Activate cinematic camera
        public void ActivateCinematicCamera(Camera cinematicCamera = null)
        {
            if (cinematicCamera != null)
            {
                _cinematicCamera = cinematicCamera;

                //Enable cinematic camera
                _cinematicCamera.gameObject.SetActive(true);
            }

            //Disable player camera
            _camera.gameObject.SetActive(false);
        }

        //Deactivate cinematic camera
        public void DeactivateCinematicCamera()
        {
            if (_cinematicCamera != null)
                //Disable cinematic camera
                _cinematicCamera.gameObject.SetActive(false);

            //Enable player camera
            _camera.gameObject.SetActive(true);

            _cinematicCamera = null;
        }
    }
}