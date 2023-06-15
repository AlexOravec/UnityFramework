using UnityEngine;

namespace BaseClasses
{
    public class Actor : Object
    {
        // Get the actor's location
        public Vector3 GetActorLocation()
        {
            return transform.position;
        }

        //Get actor's rotation
        public Quaternion GetActorRotation()
        {
            return transform.rotation;
        }

        //Get actor's scale
        public Vector3 GetActorScale()
        {
            return transform.localScale;
        }

        //Get actor's forward vector
        public Vector3 GetActorForward()
        {
            return transform.forward;
        }

        //Get actor's right vector
        public Vector3 GetActorRight()
        {
            return transform.right;
        }
    }
}