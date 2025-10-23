using UnityEngine;

namespace JacobHomanics.Essentials.RPGController
{
    [CreateAssetMenu(fileName = "PlayerMotorKeybindsScriptableObject", menuName = "Scriptable Objects/PlayerMotorKeybindsScriptableObject")]
    public class PlayerMotorKeybindsScriptableObject : ScriptableObject
    {
        // WoW style config:
        // forward: W
        // backward: S
        // left: Q
        // right: E
        // jump: Space

        public Combo[] fowardCombos;
        public Combo[] backwardCombos;
        public Combo[] leftCombos;
        public Combo[] rightCombos;

        public Combo[] jumpCombos;
    }
}