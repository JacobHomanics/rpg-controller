using UnityEngine;

namespace JacobHomanics.Essentials.RPGController
{
    public class CursorIconManager : MonoBehaviour
    {
        public Texture2D tex;
        public bool useDefaultCursor;

        void Update()
        {
            if (useDefaultCursor)
            {
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            }
            else
            {
                Cursor.SetCursor(tex, Vector2.zero, CursorMode.Auto);
            }
        }
    }
}