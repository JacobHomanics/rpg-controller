using UnityEngine;

namespace JacobHomanics.Essentials.RPGController
{
    [System.Serializable]
    public struct MotorValues
    {
        public float leftMoveSpeed;
        public float rightMoveSpeed;
        public float forwardMoveSpeed;
        public float backwardMoveSpeed;
        public Vector3 gravity;
        public float jumpPower;
        public float midAirMovementPercentage;
    }

    [CreateAssetMenu(fileName = "PlayerMotorScriptableObject", menuName = "Scriptable Objects/PlayerMotorScriptableObject")]
    public class PlayerMotorScriptableObject : ScriptableObject
    {
        // WoW style config:
        // left: 2.5f
        // right: 2.5f
        // forward: 2.5f
        // backward: 1.65f
        // gravity: (0, 9.81f, 0)
        // jumpPower: 15
        // midAirMovementPercentage: 0.55f

        public MotorValues motorValues = new()
        {
            leftMoveSpeed = 2.5f,
            rightMoveSpeed = 2.5f,
            forwardMoveSpeed = 2.5f,
            backwardMoveSpeed = 1.65f,
            gravity = new(0, 9.81f, 0),
            jumpPower = 15f,
            midAirMovementPercentage = .55f
        };
    }
}