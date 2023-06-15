using UnityEngine;

namespace BaseClasses
{
    public abstract class Pawn : Actor
    {
        // Base class for all pawns in the game.

        //Controller of the Pawn.
        private Controller _controller;

        //Movement input of the pawn.
        private Vector2 _movementInput;

        //Method to set the controller of the pawn.
        public void SetController(Controller newController)
        {
            _controller = newController;
        }

        //Method to get the controller of the pawn.
        public Controller GetController()
        {
            return _controller;
        }

        protected override void Destroyed()
        {
            base.Destroyed();

            // If the controller is not null
            if (_controller != null)
                // Unpossess the pawn
                _controller.UnPossess();
        }

        //Method to set the movement input of the pawn.
        public virtual void SetMovementInput(Vector2 newMovementInput)
        {
            _movementInput = newMovementInput;
        }

        //Method to get the movement input of the pawn.
        public Vector2 GetMovementInput()
        {
            return _movementInput;
        }
    }
}