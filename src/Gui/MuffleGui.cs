namespace Muffle.Gui 
{
    public class MuffleGui : GuiDialog
    {
        // This tells the game to link this specific GUI to your 'P' keybind
        public override string ToggleKeyCombinationCode => "mufflemenu";

        // This makes the ESC key close the menu before opening the pause screen
        public override EnumDialogType DialogType => EnumDialogType.Dialog;

        public MuffleGui(ICoreClientAPI capi) : base(capi)
        {
            // Setup your sliders and buttons here
        }
    }
}