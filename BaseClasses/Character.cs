using UnityEngine;

namespace BaseClasses
{
    [RequireComponent(typeof(HealthManager))]
    public class Character : Pawn
    {
        //Move speed
        private float _currentMaxWalkSpeed;

        // The player health manager that this controller is currently controlling.
        private HealthManager _healthManager;

        private bool _isGrounded;

        //Current velocity
        private Vector3 _velocity = Vector3.zero;

        protected override void Initialize()
        {
            base.Initialize();

            // Get the health manager.
            _healthManager = GetComponent<HealthManager>();
        }

        //Jump method
        public virtual void Jump()
        {
        }

        //Crouch method
        public virtual void Crouch()
        {
           
        }

        //Sprint method
        public virtual void Sprint()
        {
            
        }
        
        //Stop sprint method
        public virtual void StopSprint()
        {
           
        }

        protected virtual void AddControllerYawInput(float value)
        {
            // Get current rotation
            var currentRotation = transform.rotation;

            // Calculate new rotation
            var newRotation = Quaternion.Euler(0.0f, value, 0.0f) * currentRotation;

            // Set new rotation
            transform.rotation = newRotation;
        }

        protected virtual void AddControllerPitchInput(float value)
        {
            //Get player camera manager
            var cameraManager = (GetController() as PlayerController)?.GetPlayerCameraManager() as PlayerCameraManager;

            // Check if camera manager is valid
            if (cameraManager != null)
                // Add pitch input
                cameraManager.AddPitch(value);
            else
                Debug.LogError("Camera manager is not valid");
        }

        // Get player health manager.
        public HealthManager GetPlayerHealthManager()
        {
            return _healthManager;
        }
        
    }
}