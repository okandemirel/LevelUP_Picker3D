using System;

namespace Data.ValueObject
{
    [Serializable]
    public class PlayerData
    {
        public PlayerMovementData MovementData;
        public PlayerThrowForceData ThrowForceData;
    }

    [Serializable]
    public class PlayerMovementData
    {
        public float ForwardSpeed = 5;
        public float SidewaysSpeed = 2;
        public float ForwardForceSpeed = 10;
    }

    [Serializable]
    public class PlayerThrowForceData
    {
        public float ThrowForce = 10;
    }
}