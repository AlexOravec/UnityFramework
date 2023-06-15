namespace BaseClasses
{
    public class Controller : Object
    {
        // The pawn that this controller is currently controlling
        private Pawn _pawn;

        //Possess a pawn
        public virtual void Possess(Pawn pawn)
        {
            //If we are already possessing a pawn, unpossess it
            if (_pawn != null) UnPossess();

            //Set the pawn
            _pawn = pawn;

            //Set the pawn's controller
            _pawn.SetController(this);
        }


        //Unpossess the pawn
        public void UnPossess()
        {
            //If we are not possessing a pawn, return
            if (_pawn == null) return;

            //Set the pawn's controller to null
            _pawn.SetController(null);

            //Set the pawn to null
            _pawn = null;
        }

        //Get the pawn that this controller is currently controlling
        public Pawn GetPawn()
        {
            return _pawn;
        }
    }
}