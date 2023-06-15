using UnityEngine;

namespace BaseClasses
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class PlayerStart : Actor
    {
        private Character _playerCharacter;

        // On Gui show forwad vector
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + transform.forward);

            //Find Game Mode
            var gameMode = FindObjectOfType<GameMode>();

            //If game mode is not null  
            if (gameMode != null && gameMode.playerCharacter != null)
                //If player character is not null
                if (_playerCharacter == null || _playerCharacter != gameMode.playerCharacter)
                {
                    _playerCharacter = gameMode.playerCharacter;

                    //Get capsule collider
                    var capsuleCollider = GetComponentInChildren<CapsuleCollider>();

                    //If capsule collider is not null
                    if (capsuleCollider != null)
                        //Set player character position
                        capsuleCollider.height = _playerCharacter.GetComponentInChildren<CapsuleCollider>().height;
                }
        }
    }
}