using UnityEngine;

namespace JacobHomanics.Essentials.RPGController
{
    [CreateAssetMenu(fileName = "PlayerRotatorScriptableObject", menuName = "Scriptable Objects/PlayerRotatorScriptableObject")]
    public class PlayerRotatorScriptableObject : ScriptableObject
    {
        // WoW style config:
        // left: 150f
        // right: 150f

        public float leftTurnSpeed = 150f;
        public float rightTurnSpeed = 150f;
    }
}