using UnityEngine;

namespace BaseClasses
{
    [RequireComponent(typeof(CameraManager))]
    public class PlayerController : Controller
    {
        // Base class for player controllers.
        // Player controllers are responsible for controlling the player's view of the world, and for processing player input.
        // Player controllers are created by the game mode when a player logs in.
        // Player controllers are destroyed when the player logs out.

        // The player camera manager that this controller is currently controlling.
        private CameraManager _cameraManager;

        // Is input enabled?
        private bool _inputEnabled = true;

        protected override void Initialize()
        {
            base.Initialize();

            // Get the camera manager.
            _cameraManager = GetComponent<CameraManager>();
        }

        //Get the camera manager.
        public CameraManager GetPlayerCameraManager()
        {
            return _cameraManager;
        }

        public override void Possess(Pawn pawn)
        {
            if (pawn == null) return;

            base.Possess(pawn);

            if (_cameraManager != null)
                // Set the camera manager to control the pawn.
                _cameraManager.SetView(pawn);
        }

        //Set input enabled.
        public void SetInputEnabled(bool inputEnabled)
        {
            _inputEnabled = inputEnabled;
        }

        //Get input enabled.
        protected bool GetInputEnabled()
        {
            return _inputEnabled;
        }
    }
}