using UnityEngine;

public class StateConstant
{
    public static readonly int STATE_HASH = Animator.StringToHash("State");

    public static readonly Vector3 FACE_RIGHT = Vector3.one;
    public static readonly Vector3 FACE_LEFT = new Vector3(-1, 1, 1);
    public interface StateAnimation
    {
        public const int IDLE = 0;
        public const int RUN = 1;
        public const int JUMP = 2;
        public const int HITED = 3;
    }
}
