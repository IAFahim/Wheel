using UnityEngine;

namespace Editor.Tools.Wheel
{ 
    internal static class EditorIconUrlOpen
    {
        [CircularMenu("IconURL" , "console.infoicon@2x")]
        public static void Open()
        {
            Application.OpenURL("https://github.com/Zxynine/UnityEditorIcons#file-id");
        }
    }
}
