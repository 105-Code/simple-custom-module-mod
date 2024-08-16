using ModLoader;
using SFS.Input;
using UnityEngine;

namespace SimpleMod
{
    public class KeySettings : ModKeybindings
    {
        public static KeySettings Main;

        public KeybindingsPC.Key Key_Test = KeyCode.Y;

        public static void Setup()
        {
            Main = SetupKeybindings<KeySettings>(SimpleModPack.Main.Mod);
        }

        public override void CreateUI()
        {
            KeySettings keySettings = new KeySettings(); // default keybindings
            base.CreateUI_Text("Simple Mod");
            base.CreateUI_Keybinding(Key_Test, keySettings.Key_Test, "Test Key");
        }
    }
}
