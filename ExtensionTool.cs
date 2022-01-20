using UnityEditor.SceneTemplate;
using UnityEngine;
namespace Playtika_artyoms
{
    public static class MyPackage
    {
        public static void Move(this Transform t)
        {
            float xPos = Input.GetAxis("Horizontal");
            t.position = new Vector3(xPos, 0, 0);
        }
    }
}
